using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using Photon.Voice.Unity;
using Photon.Voice.PUN;
using UnityEngine.UI;

public class PushToTalk : MonoBehaviourPun
{
    

    public Recorder VoiceRecorder;

    private PhotonView voiceView;


    // Start is called before the first frame update
    void Start()
    {
        voiceView = photonView;
        VoiceRecorder.TransmitEnabled = false;

        
    }

    // Update is called once per frame
    void Update()
    {
        Button VoiceButton = GameObject.FindGameObjectWithTag("Voice").GetComponent<Button>();
        VoiceButton.onClick.AddListener(() => VoiceChatOn());
        Button VoiceButton2 = GameObject.FindGameObjectWithTag("Noice").GetComponent<Button>();
        VoiceButton2.onClick.AddListener(() => VoiceChatOff());
    }
    public void VoiceChatOn()
    {
        if(voiceView.IsMine)
        {
            if(VoiceRecorder.TransmitEnabled == false)
            {
                VoiceRecorder.TransmitEnabled = true;
            }
            
        }
    }
    public void VoiceChatOff()
    {
        if (voiceView.IsMine)
        {
            if (VoiceRecorder.TransmitEnabled == true)
            {
                VoiceRecorder.TransmitEnabled = false;
            }
        }
    }
   
}

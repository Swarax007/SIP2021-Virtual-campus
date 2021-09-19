using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using agora_gaming_rtc;
using Photon.Pun;

public class VoiceChatManager : MonoBehaviourPunCallbacks
{
    string appID = "ebf5a04701e64da1ada2f536b1164a7f";

    public static VoiceChatManager Instance;

    IRtcEngine rtcEngine;

    private void Awake()
    {
        if (Instance)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    private void Start()
    {
        rtcEngine = IRtcEngine.GetEngine(appID);
        rtcEngine.OnJoinChannelSuccess += OnJoinChannelSuccess;
        rtcEngine.OnLeaveChannel+= OnLeaveChannel;
        rtcEngine.OnError += OnError;
    }
    void OnJoinChannelSuccess(string channelName, uint uid, int elapsed)
    {
        Debug.Log("Joined Channel Success: " + channelName);
    }
    void OnLeaveChannel(RtcStats stats)
    {
        Debug.Log("Left Channel with duration" + stats.duration);
    }
    void OnError(int error, string msg)
    {
        Debug.LogError("error with agora: " + msg);
    }

   

    public override void OnJoinedRoom()
    {
        rtcEngine.SetDefaultAudioRouteToSpeakerphone(true);
        rtcEngine.JoinChannel(PhotonNetwork.CurrentRoom.Name);
    }
    public override void OnLeftRoom()
    {
        rtcEngine.LeaveChannel();
    }
    private void OnDestroy()
    {
        IRtcEngine.Destroy();
    }
    
}
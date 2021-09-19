using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class LeaveRoom : MonoBehaviourPunCallbacks
{
    public GameObject ExitBox;
    public void LeaveButton()
    {


        PhotonNetwork.LeaveRoom();
        OnLeaveRoom();
       
    }
    public void OnLeaveRoom()
    {
        PhotonNetwork.LoadLevel(2);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ExitBox.SetActive(true);

        }
    }
    public void ExitButton()
    {
        Application.Quit();
    }
    public void CancelButton()
    {
        ExitBox.SetActive(false);
        
    }
}

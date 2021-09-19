using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class CameraFollow : MonoBehaviour
{

    private Transform target;

    [SerializeField]
    private float minX, maxX;

    [SerializeField]
    private float minY, maxY;

    private Vector3 tempPos;

    

    private void Start()
    {
       

    }
   

 


    void Update()
    {
        GameObject Player = GameObject.Find("Player(Clone)");

        if (Player)
        {
            target = Player.transform;
        }
        else
        {
            Debug.Log("Clone not found");
        }
        if (target != null)
        {
            transform.position = new Vector3(target.transform.position.x, target.transform.position.y, transform.position.z);

            tempPos = transform.position;

            if (tempPos.x < minX)
            {
                tempPos.x = minX;
            }
            if (tempPos.x > maxX)
            {
                tempPos.x = maxX;
            }
            if (tempPos.y < minY)
            {
                tempPos.y = minY;
            }
            if (tempPos.y > maxY)
            {
                tempPos.y = maxY;
            }

            transform.position = tempPos;
        }
    }
}

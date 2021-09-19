using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public static Main Instance;

    public ToServer Web;

    public Loader load;

    public SpawnPlayers spawn;

    public PushToTalk push;
    void Start()
    {
        Instance = this;
        Web = GetComponent<ToServer>();
        load = GetComponent<Loader>();
        spawn = GetComponent<SpawnPlayers>();
        push = GetComponent<PushToTalk>();
    }

}

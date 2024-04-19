using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class AutoHostClient : MonoBehaviour
{
    [SerializeField]
    NetworkManager networkManager;

    public bool isServer = false;
    void Start()
    {
        if (!isServer)
        {
            Debug.Log($"  client connected");
            networkManager.StartClient();
        }
        else
        {
            Debug.Log($" server start ");
            networkManager.StartHost();
        }
    }
    public void JoinLocal()
    {
        networkManager.networkAddress = "LocalHost";
        networkManager.StartClient();
    }
}

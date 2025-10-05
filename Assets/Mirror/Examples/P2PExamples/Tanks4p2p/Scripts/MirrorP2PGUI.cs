using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

public class MirrorP2PGUI : MonoBehaviour
{
    private NetworkManager manager;
    private P2PSettings settings { get; set; }
    void Start()
    {
        TryGetComponent(out manager);       
    }
    void OnGUI()
    {
        // Make a background box
        GUILayout.Box("P2P Info");

        // Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
        if (GUILayout.Button("Get P2P Settings Info"))
        {
            settings = manager.P2PSettings;
        }

        GUILayout.Label($"Next Address: {settings.nextAddress}");
        GUILayout.Label($"Connection Record: {settings.connectionRecord}");

    }
}

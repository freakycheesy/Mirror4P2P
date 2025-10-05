using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

public class MirrorP2PInfo : MonoBehaviour
{
    private NetworkManager manager;
    private string nextAddress { get; set; }
    void Start()
    {
        TryGetComponent(out manager);       
    }
    void OnGUI()
    {
        // Make a background box
        GUILayout.Box("P2P Info");

        // Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
        if (GUILayout.Button("Get P2P NextAddress"))
        {
            nextAddress = manager.P2PNextAddress;
        }

        GUILayout.Label($"Next Address: {nextAddress}");

    }
}

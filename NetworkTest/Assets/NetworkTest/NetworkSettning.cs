using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class NetworkSettning : MonoBehaviour {

	// Use this for initialization
	void Start () {

        var man = GetComponent<NetworkManager>();
#if UNITY_WSA
        man.StartHost();
#else
        man.StartClient();
#endif
    }

    // Update is called once per frame
    void Update () {
        
        

    }
}

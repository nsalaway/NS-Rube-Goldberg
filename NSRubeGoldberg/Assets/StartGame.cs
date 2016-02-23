using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {

    public GameObject starter;
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
            Destroy(starter);
	}
}

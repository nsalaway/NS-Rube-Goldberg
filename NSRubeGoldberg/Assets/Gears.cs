using UnityEngine;
using System.Collections;

public class Gears : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, 10f * Time.deltaTime, 0);
	
	}
}

using UnityEngine;
using System.Collections;

public class SecondPersonView : MonoBehaviour {

	// Use this for initialization
    public Transform Cam_Pos;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Cam_Pos.position;
        transform.forward = Cam_Pos.forward;
	}
}

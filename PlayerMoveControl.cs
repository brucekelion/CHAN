using UnityEngine;
using System.Collections;
[RequireComponent(typeof(Animator))]
public class PlayerMoveControl : MonoBehaviour {

	// Use this for initialization
    public Animator PlayerAnim;
    float h;
    float v;
    float forwardSpeed = 5.0f;
    float backSpeed = 3.0f;
    float RotateSpeed = 2.5f;
    public float consolevalue;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void FixedUpdate()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        PlayerAnim.SetFloat("Speed", v);
        consolevalue += Time.fixedDeltaTime*0.5f;
        PlayerAnim.SetFloat("Direction", h);
        PlayerAnim.speed = 1.23f;
        Vector3 velocity = new Vector3(0, 0, v);
        velocity = transform.TransformDirection(velocity);
        if (v > 0.2f)
            velocity *= forwardSpeed;
        else if (v < -0.2f)
            velocity *= backSpeed;
        transform.position += velocity * Time.fixedDeltaTime;
        transform.Rotate(new Vector3(0, h * RotateSpeed, 0));
    }
}

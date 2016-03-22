using UnityEngine;
using System.Collections;

public class BallMoveControl : MonoBehaviour {

	// Use this for initialization
    public Transform PlaneTra;
    Vector3 ballMoveDirection;
    Transform hitPoint;
    Collision ballCollision;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void FixedUpdate()
    {
        ballMoveDirection = new Vector3(0, 0, -1);
        ballMoveDirection = transform.TransformDirection(ballMoveDirection);
        //Vector3 direction = PlaneTra.position - transform.position;
        //rigidbody.AddForceAtPosition(direction.normalized * 5.0f, transform.position);
        rigidbody.AddForce(Vector3.down * 300);
        transform.position += Vector3.back * Time.fixedDeltaTime * 15;
        transform.Rotate(Vector3.left,Time.fixedDeltaTime*200,Space.Self);
    }
    void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contract in collision.contacts)
        {

        }
    }
}

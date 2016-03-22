using UnityEngine;
using System.Collections;

public class CollisionEffect : MonoBehaviour {

	// Use this for initialization
    public GameObject Stone;
    private GameObject stone;
	void Start () {
        //stone = Instantiate(Stone, Vector3.zero,transform.rotation) as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Plane")
        {
            stone = Instantiate(Stone, Vector3.zero, transform.rotation) as GameObject;
            stone.transform.position = collision.contacts[0].point;
            stone.GetComponent<ParticleEmitter>().minSize = 2.5f;
            stone.GetComponent<ParticleEmitter>().maxSize = 3;
            stone.GetComponent<ParticleEmitter>().Emit();
        }
    }
}

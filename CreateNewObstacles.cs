using UnityEngine;
using System.Collections;
using System;

public class CreateNewObstacles : MonoBehaviour
{

    // Use this for initialization
    public GameObject FireBall;
    private GameObject fireBallClone;
    private GameObject fireBallClone1;
    private Vector3 originalP;
    private Quaternion originalR;
    public bool isVisible = true;
    public bool cloneVisible = false;
    public float generateTime = 0;
    System.Random rand = new System.Random();
    float randomNum;
    void Start()
    {
        originalP = GameObject.Find("FireBall").transform.position;
        originalR = GameObject.Find("FireBall").transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (!FireBall.renderer.isVisible && Time.time > 1.0f)
        {
            isVisible = false;
            randomNum = rand.Next() % 10 * 1.0f;
            if (GameObject.Find("FireBall").transform.position.y < 6.0f && GameObject.Find("FireBall").transform.position.y > 5.5f)
            {
                generateTime = Time.time;
                fireBallClone = Instantiate(FireBall, new Vector3(originalP.x, originalP.y, originalP.z), originalR) as GameObject;
                fireBallClone1 = Instantiate(FireBall, new Vector3(originalP.x+5, originalP.y, originalP.z), originalR) as GameObject;
                GameObject.Destroy(GameObject.Find("FireBall"));
            }
            if (fireBallClone != null)
            {
                cloneVisible = fireBallClone.renderer.isVisible;
                fireBallClone.name = "FireBall";
            }
        }
        else
        {
            isVisible = true;
        }
        //if (GameObject.Find("FireBall") != null)
        //{
        //    if (!fireBallClone.renderer.isVisible && Time.time > 1+generateTime)
        //        GameObject.Destroy(fireBallClone);
        //}
    }
}

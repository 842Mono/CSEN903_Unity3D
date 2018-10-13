using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercrlt4 : MonoBehaviour
{

	//public GameObject camera;
	// public GameObject tel;
	// public GameObject es;
	// Use this for initialization
	void Start () {
		Debug.Log("weird");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void FixedUpdate()
	{
	  if(Input.GetKey("up"))
	  {
        this.transform.Translate(0,0,0.1f);
		
        //camera.transform.Translate(0,0,0.1f);
	  }
	  if(Input.GetKey("down"))
	  {
        this.transform.Translate(0,0,-0.1f);
		
        //camera.transform.Translate(0,0,-0.1f);
	  }
	  if(Input.GetKey("left"))
	  {
        this.transform.Translate(-0.1f,0,0);
	  }
	  if(Input.GetKey("right"))
	  {
        this.transform.Translate(0.1f,0,0);
	  }
	}

	// void OnCollisionEnter(Collision other)
	// {
	// 	Debug.Log("test");
	// }
	// void OnTriggerEnter(Collider other)
	// {
	// 	if(other.tag == "Finish")
	// 		Destroy(this.gameObject);
	// 	else if(other.tag == "Respawn")
	// 		this.transform.position = tel.transform.position;
	// 	else if(other.tag == "done")
	// 		Destroy(es.gameObject);
	// }

	void OnTriggerEnter(Collider other)
	{
		Debug.Log("test");
	}
}

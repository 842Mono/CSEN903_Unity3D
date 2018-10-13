using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeCollect : MonoBehaviour
{

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		Debug.Log("3a");
		this.transform.position = new Vector3(Random.Range(-4.5f, 4.5f), 0.5f, Random.Range(-5f, 5f));
	}
}

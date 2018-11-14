using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.

public class cubesctrl : MonoBehaviour
{

	public GameObject cubePrefab;
	public Transform parent;

	// Use this for initialization
	void Start ()
	{
		Instantiate(cubePrefab, new Vector3(Random.Range(-4.5f, 4.5f), 0.5f, Random.Range(-5f, 5f)), Quaternion.identity, parent);
		Debug.Log("test");
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}


}

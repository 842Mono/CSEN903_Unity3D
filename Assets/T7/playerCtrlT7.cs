using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCtrlT7 : MonoBehaviour
{
	public GameObject destination;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.Space))
		{
			destination.transform.position = gameObject.transform.position;
		}
		if(Input.GetKey(KeyCode.UpArrow))
		{
			gameObject.transform.Translate(0.1f, 0, 0);
		}
		if(Input.GetKey(KeyCode.DownArrow))
		{
			gameObject.transform.Translate(-0.1f, 0, 0);
		}
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			gameObject.transform.Translate(0, 0, 0.1f);
		}
		if(Input.GetKey(KeyCode.RightArrow))
		{
			gameObject.transform.Translate(0, 0, -0.1f);
		}
	}
}

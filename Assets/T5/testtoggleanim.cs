using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testtoggleanim : MonoBehaviour
{
	public Animator a;



	// Use this for initialization
	void Start ()
	{
		a = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.Space))
		{
			bool t = a.GetBool("that");
			a.SetBool("that", !t);
		}
	}


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animErica : MonoBehaviour
{
	public Animator thisAnimator;

	// Use this for initialization
	void Start ()
	{
		thisAnimator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.E))
		{
			thisAnimator.SetBool("equip", true);
		}
		if(Input.GetKeyDown(KeyCode.Space))
		{
			thisAnimator.SetBool("draw", true);
		}
		if(Input.GetKeyUp(KeyCode.Space))
		{
			thisAnimator.SetBool("draw", false);
		}

	}
}

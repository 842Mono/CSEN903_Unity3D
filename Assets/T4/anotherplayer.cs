using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class anotherplayer : MonoBehaviour
{
	public Text score;
	private int scoreInt = 0;
	public Text timer;
	private double timeDouble = 21;
	// Use this for initialization
	void Start () {
		
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
	  

	  Debug.Log(Time.deltaTime);
	  timeDouble = timeDouble - Time.deltaTime;
	  timer.text = timeDouble < 0 ? "0" : ((int)timeDouble).ToString();
	  if(timeDouble <= 0)
	  {
		  Debug.Log("done");
	  }
	}

	void OnTriggerEnter(Collider other)
	{
		// Debug.Log("test");
		// Debug.Log(other);
		++this.scoreInt;
		score.text = scoreInt.ToString();
		if(timeDouble <= 0)
			Destroy(other.gameObject);
	}
}

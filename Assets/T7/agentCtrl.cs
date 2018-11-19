using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class agentCtrl : MonoBehaviour
{
	public Transform[] points;
	private int destPoint = 0;

	NavMeshAgent thisNavMeshAgent;
	NavMeshAgent agent;
	public GameObject basePoint;
	public GameObject destination;


	// Use this for initialization
	void Start ()
	{
		thisNavMeshAgent = gameObject.GetComponent<NavMeshAgent>();
		//thisNavMeshAgent.SetDestination(destination.transform.position);
		agent = thisNavMeshAgent;
		points = new Transform[]{ basePoint.transform, destination.transform };

		// Disabling auto-braking allows for continuous movement
		// between points (ie, the agent doesn't slow down as it
		// approaches a destination point).
		thisNavMeshAgent.autoBraking = false;

		GotoNextPoint();
		Debug.Log(gameObject.transform.position);
	}


	void GotoNextPoint() {
		// Returns if no points have been set up
		if (points.Length == 0)
			return;

		// Set the agent to go to the currently selected destination.
		agent.destination = points[destPoint].position;
		Debug.Log(points[0].transform.position);
		Debug.Log(points[1].transform.position);

		// Choose the next point in the array as the destination,
		// cycling to the start if necessary.
		destPoint = (destPoint + 1) % points.Length;
	}


	void Update () {
		// Choose the next destination point when the agent gets
		// close to the current one.
		if (!agent.pathPending && agent.remainingDistance < 0.5f)
			GotoNextPoint();
	}
}

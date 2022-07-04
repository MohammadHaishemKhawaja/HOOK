using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportSphere : MonoBehaviour
{

	public map1 mapScript;

	private int timesHit;
	public GameObject thePlayer;
	public Transform[] destination;
	public GrappleHook hookScript;
	public int destination1;
	void OnTriggerEnter(Collider other)
	{
		destination1 = Random.Range(1, 4);
		other.transform.position = destination[(destination1)].transform.position;
		timesHit = timesHit + 1;
		hookScript.doGrapple = false;

		mapScript.randomizeRamps();
	}

	}
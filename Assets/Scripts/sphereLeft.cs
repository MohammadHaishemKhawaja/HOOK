using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereLeft : MonoBehaviour
{
	public GameObject sphereMove; 
	public int sphereLeft1; 
	public bool sphereLeftBool = false;

	void Start()
	{
		sphereLeftBool = false;



	}
	public void Update(){


		if (sphereLeftBool == true) {

			leftSphere();

		}
		if (sphereLeftBool == false) {

			leftSphere1();

		}
	}

	// Update is called once per frame
	public void leftSphere()
	{


		sphereLeft1 = sphereLeft1 + 1;
		sphereMove.transform.rotation = Quaternion.Euler(0.0f, sphereLeft1, 0.0f);


	}
	public void leftSphere1()
	{


		sphereLeft1 = sphereLeft1 - 1;
		sphereMove.transform.rotation = Quaternion.Euler(0.0f, sphereLeft1, 0.0f);


	}

	public void setBoolTrue()
	{


		sphereLeftBool = true;


	}



}

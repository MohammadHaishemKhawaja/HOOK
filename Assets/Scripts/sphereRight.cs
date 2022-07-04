using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereRight : MonoBehaviour
{
	public GameObject sphereMove; 
	public float sphereRight1; 
	public bool sphereRightBool = false;
	public sphereRight sphereScript;
	// Start is called before the first frame update
	void Start()
	{
		sphereRightBool = false;
		print(sphereRightBool);


	}
	public void Update(){


		if (sphereRightBool == true) {
		rightSphere();

	}
		if (sphereRightBool == false) {
			rightSphere1();

		}
	}

	// Update is called once per frame
	public void rightSphere()
	{


			sphereRight1 = sphereRight1 + 0.1f;
			sphereMove.transform.rotation = Quaternion.Euler(0.0f, sphereRight1, 0.0f);

		
	}
	public void rightSphere1()
	{

	

		sphereMove.transform.rotation = Quaternion.Euler(0.0f, sphereRight1, 0.0f);


	}

	public void setBoolTrue()
	{


		sphereRightBool = true;


	}

}

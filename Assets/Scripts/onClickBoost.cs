using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onClickBoost : MonoBehaviour
{
	public float jumpSpeed = -114.012f;
	public float jumpSpeed1 = 4.099f;
	private Rigidbody rigidBody;


    // Start is called before the first frame update
    void Start()
    {
		rigidBody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
		
		rigidBody.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse); 
		rigidBody.AddForce(Vector3.forward * jumpSpeed1, ForceMode.Impulse); 


    }
	public void addJumpSpeed1(){

		jumpSpeed1 = jumpSpeed1 + 8.050f;
		jumpSpeed = jumpSpeed + 16.003f;


	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraLookAround : MonoBehaviour
{
	public Transform lookAt;
	public Transform camTransform;
	public static float brightness;
	private const float Y_ANGLE_MIN = -50.0f;
	private const float Y_ANGLE_MAX = 40.0f;
	private const float X_ANGLE_MIN = -50.0f;
	private const float X_ANGLE_MAX = 40.0f;
	private Camera cam;

	private float distance = 10.0f;
	private float currentX = 0.0f;
	private float currentY = 0.0f;
	private float sensitivityX = 4.0f;
	private float sensitivityY =  1.0f;

	private void Start()
	{
		
		Cursor.visible = false;
		camTransform = transform;
		cam = Camera.main;
	}
	private void Update(){

		currentX += Input.GetAxis("Mouse X");
		currentY += Input.GetAxis("Mouse Y");
		currentY = Mathf.Clamp(currentY, Y_ANGLE_MIN, Y_ANGLE_MAX);
		currentX = Mathf.Clamp(currentX, X_ANGLE_MIN, X_ANGLE_MAX);
	}

	private void LateUpdate(){

		Vector3 dir = new Vector3(0,0, -distance);
		Quaternion rotation = Quaternion.Euler(currentY,currentX,0);
		camTransform.position = lookAt.position + rotation * dir;
		camTransform.LookAt(lookAt.position);
	}
}
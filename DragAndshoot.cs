using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]

public class DragAndshoot : MonoBehaviour {

	// Use this for initialization
	private Vector3 mousePressDownPos;
	private Vector3 mouseReleasePos;

	private Rigidbody rb;

	public bool isShoot;//to check if the ball shot

	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	private void OnMouseDown()
	{
		mousePressDownPos = Input.mousePosition;
	}

	private void OnMouseUp()
	{
		mouseReleasePos = Input.mousePosition;

		Shoot(mouseReleasePos-mousePressDownPos);
	}

	private float forceMultiplier = 3;
	//this function add froce * 3 for to shoot the ball
	void Shoot(Vector3 Force)
	{
		if(isShoot)    
			return;

		rb.AddForce(new Vector3(Force.x,Force.y,Force.y) * forceMultiplier);
		isShoot = true;
	}
}

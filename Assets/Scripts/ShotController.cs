using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotController : MonoBehaviour 
{
	public float speed = 5f;
	public float destroyDistance = 800f;



	void Update () {

		ManageShotMovement();

	}



	void ManageShotMovement()
	{
		Vector3 nextPos = new Vector3(transform.position.x, transform.position.y, transform.position.z + speed);
		transform.position = nextPos;

		if (destroyDistance != 0f && transform.position.z > destroyDistance) {
			Destroy(gameObject);
		}
	}



	void OnTriggerEnter(Collider other) 
	{	
		Destroy(gameObject);
		
		Debug.Log("collided");
	}
}

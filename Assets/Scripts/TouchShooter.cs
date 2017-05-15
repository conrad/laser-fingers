using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchShooter : MonoBehaviour 
{
	public GameObject shot;



	void Update () 
	{
		FireLasersFromWhereTouched();
		FireLasersFromWhereClicked();

//		FireLaserTowardWhereClicked();
	}



	void FireLasersFromWhereTouched()
	{
		foreach (Touch touch in Input.touches) {
			Instantiate(shot, touch.position, Quaternion.identity);
		}
	}



	void FireLasersFromWhereClicked()
	{
		if (Input.GetMouseButtonDown(0)) {
			Instantiate(shot, MapMousePositionToScreen(Input.mousePosition), Quaternion.identity);
		}
	}



	void FireLaserTowardWhereClicked()
	{
		if (Input.GetMouseButtonDown(0)) {
			Vector3 source = new Vector3(7f, 1f, -1f);

			Instantiate(shot, source, Quaternion.LookRotation(MapMousePositionToScreen(Input.mousePosition)));
		}

	}


	Vector3 MapMousePositionToScreen(Vector3 mousePosition)
	{
		float shotX = mousePosition.x / Screen.width * 14f;
		float shotY = mousePosition.y / Screen.height * 6.5f;

		return new Vector3(shotX, shotY, 0f);
	}
}

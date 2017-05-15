using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealityController : MonoBehaviour 
{
	void Start () {
		WebCamTexture mCamera = new WebCamTexture ();
		gameObject.GetComponent<MeshRenderer>().material.mainTexture = mCamera;
//		plane.renderer.material.mainTexture = mCamera;
		mCamera.Play ();
	}
}

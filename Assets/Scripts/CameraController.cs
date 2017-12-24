using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform charTransform;
    public Vector3 offset;

    public float xMin, xMax, yMin, yMax;
	
	// Update is called once per frame
	void Update ()
    {

        Vector3 position = new Vector3(Mathf.Clamp(charTransform.position.x, xMin, xMax), Mathf.Clamp(charTransform.position.y, yMin, yMax), charTransform.position.z);
        transform.position = position + offset;

	}

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Weight : MonoBehaviour {
	LineRenderer line; 
	DistanceJoint2D distanceJoint; 


	void Start () {
		distanceJoint = GetComponent<DistanceJoint2D>(); 
		line = GetComponent<LineRenderer>(); 

	}


	void Update () {
		line.SetPosition(0, transform.position); 
		line.SetPosition(1,distanceJoint.connectedBody.transform.position); 
	}
}

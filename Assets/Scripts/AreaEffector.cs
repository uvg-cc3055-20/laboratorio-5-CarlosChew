//CARLOS HUMBERTO CHEW ROLDAN 
//CARNET --- 17507
//PLATAFORMAS MOLVILES Y JUEGOS 


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEffector : MonoBehaviour {
	public float time;
	public GameObject child; 
	public GameObject child2; 
	bool active = true; 
	void Start () {

	}


	void Update () {
		time = time + Time.deltaTime;
		if(time >= 3f)
		{
			active = !active; 
			child.SetActive(active); 
			child2.SetActive(active);
			time = 0; 
		}
	}
}

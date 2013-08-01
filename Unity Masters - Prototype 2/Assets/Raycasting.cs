using UnityEngine;
using System.Collections;

public class Raycasting : MonoBehaviour {
	float distance;
	string objectAimed = "";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	RaycastHit hit;
		if(Physics.Raycast(transform.position,transform.TransformDirection( Vector3.forward), out hit,1000.0f)){
			objectAimed = hit.collider.name;
			distance = hit.distance;
			Debug.DrawRay(transform.position, transform.TransformDirection( Vector3.forward) * hit.distance,Color.red);
		}
	}
	
	void OnGUI(){
	}
}


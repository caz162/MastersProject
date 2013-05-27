using UnityEngine;
using System.Collections;

public class NN : MonoBehaviour {
	GameObject area;
	

	// Use this for initialization
	void Start () {
		area = GameObject.FindGameObjectWithTag("2");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnGUI(){
		GUI.Label(new Rect(10, 100, 200, 20), "Distance  - " + (area.transform.position -transform.position).magnitude);	
	}
}

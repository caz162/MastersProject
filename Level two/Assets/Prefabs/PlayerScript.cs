using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody.velocity = Vector3.zero;
		
		float x = Input.GetAxis("Vertical") * Time.deltaTime *10;
		float rotate = Input.GetAxis("Horizontal") * Time.deltaTime *90;
		
		transform.Rotate(0,rotate,0);
		transform.Translate(0,0,x);
	}
	

}

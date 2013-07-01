using UnityEngine;
using System.Collections;

public class ObjectScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	  void OnCollisionEnter(Collision collision) {
		if(collision.gameObject.tag == "3"){
		Debug.Log("destroying");
		Destroy(this.gameObject);
		}
	}
	
}

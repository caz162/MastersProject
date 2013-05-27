using UnityEngine;
using System.Collections;

public class ClientObject : MonoBehaviour {
	
	MyService service;
	int i =0;
		int speed =10;
	Vector3 direction;
	Random r = new Random();
		
		
	// Use this for initialization
	void Start () {
	service = new MyService();

	}
	
	// Update is called once per frame
	void Update () {
		rigidbody.velocity = Vector3.zero;
		RaycastHit hit;
		if(Physics.Raycast(transform.position,transform.TransformDirection( Vector3.forward), out hit,1000.0f)){
			string objectAimed = hit.collider.name;
			float distance = hit.distance;
			Debug.DrawRay(transform.position, transform.TransformDirection( Vector3.forward) * hit.distance,Color.red);
		}
		float b = service.RunNN(int.Parse( hit.collider.tag));
		
		transform.Rotate(new Vector3(0, direction.y + b,0));
		transform.Translate(Vector3.forward * (Time.deltaTime* speed));
		//Debug.Log(n);
		//Debug.Log(service.RunNN());
	}
}

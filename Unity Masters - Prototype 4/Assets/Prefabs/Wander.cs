using UnityEngine;
using System.Collections;


public class Wander : MonoBehaviour {
	
	int speed =10;
	Vector3 direction;
	Random rand = new Random();
	float randomDirection;
	MyService service;
	
	// Use this for initialization
	void Start () {
	service = new MyService();
	}
	
	// Update is called once per frame
	void Update () {
		randomDirection = service.RunNN();
		//randomDirection = Random.Range(-10,10);	
		
		//direction.x = direction.x + randomDirection;
		transform.Rotate(new Vector3(0, direction.y + randomDirection,0));
		transform.Translate(Vector3.forward * (Time.deltaTime* speed));
			
	}
}

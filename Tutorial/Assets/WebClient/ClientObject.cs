using UnityEngine;
using System.Collections;

public class ClientObject : MonoBehaviour {
	
	MyService service;
	int i =0;
	int speed =10;
	Random r = new Random();
	bool firstTime = true;
	
	
	// Use this for initialization
	void Awake () {
		service = new MyService();
		//service.SetupNN();
	
	}

	
	
	IEnumerator Delay(){
		yield return new WaitForSeconds(5);	
		firstTime = false;
	}
	
	
	
	// Update is called once per frame
	void Update () {
		float randomDir = service.Rand(r,10,-10);
		Vector3 direction = new Vector3(transform.rotation.x,transform.rotation.y,transform.rotation.z);
		transform.Rotate(new Vector3(0,direction.y + randomDir,0));
		transform.Translate(Vector3.forward * (Time.deltaTime* speed));
		
	
	}
}

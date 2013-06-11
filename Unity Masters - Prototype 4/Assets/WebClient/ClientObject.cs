using UnityEngine;
using System.Collections;

public class ClientObject : MonoBehaviour {
	
	MyService service;
	int i =0;
		int speed =10;
	Vector3 direction;
	Random r = new Random();
	bool change = true;
	bool firstTime = true;
	Quaternion rotation = new Quaternion(0,0,0,0);	
	// Use this for initialization
	void Awake () {
		service = new MyService();
		service.SetupNN();
	
	}
	
	IEnumerator ChangeChromosome(){
		change = false;
		Debug.Log("waiting");
		yield return new WaitForSeconds(10);
		transform.position = new Vector3(-6.360526f,1,3.495263f);
		transform.rotation = rotation;
		
		Debug.Log("should have reset");
		service.NextItem();
		change = true;
	}
	
	IEnumerator Delay(){
		yield return new WaitForSeconds(5);	
		firstTime = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		if(firstTime){
			StartCoroutine(Delay());	
		}
		if(firstTime == false){
		if(change){
			Debug.Log("change called");
			StartCoroutine(ChangeChromosome());	
		}
		
		rigidbody.velocity = Vector3.zero;
		RaycastHit hit;
		if(Physics.Raycast(transform.position,transform.TransformDirection( Vector3.forward), out hit,1000.0f)){
			string objectAimed = hit.collider.name;
			float distance = hit.distance;
			Debug.DrawRay(transform.position, transform.TransformDirection( Vector3.forward) * hit.distance,Color.red);
		}
			//Debug.Log("running");
		float b = service.RunNN(int.Parse( hit.collider.tag));
		
		transform.Rotate(new Vector3(0, direction.y + b,0));
		transform.Translate(Vector3.forward * (Time.deltaTime* speed));
		//Debug.Log(n);
		//Debug.Log(service.RunNN());
		
	}
	}
}

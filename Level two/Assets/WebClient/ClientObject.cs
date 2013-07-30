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
	bool hit = false;
	
		
	// Use this for initialization
	void Awake () {
		service = new MyService();
		service.SetupNN();
	
	}
	
	void Hit(){
		hit = true;
	}
 	void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag == "2"){
		hit = true;	
			Destroy(other.gameObject);
		}
	}
	
	IEnumerator ChangeChromosome(){
		change = false;
		Debug.Log("waiting");
		GameObject.Find("Main Camera").SendMessage("Generate");
		yield return new WaitForSeconds(30);
		transform.position = new Vector3(-6.360526f,1,3.495263f);
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
			
		RaycastHit hit1;
		if(Physics.Raycast(transform.position,transform.TransformDirection( new Vector3(0,0,1)), out hit1,1000.0f)){
			string objectAimed = hit1.collider.name;
			float distance = hit1.distance;
			Debug.DrawRay(transform.position, transform.TransformDirection( new Vector3(0,0,1)) * hit1.distance,Color.red);
		}
			
		RaycastHit hit2;
		if(Physics.Raycast(transform.position,transform.TransformDirection( new Vector3(-1,0,1)), out hit2,1000.0f)){
			string objectAimed = hit2.collider.name;
			float distance = hit2.distance;
			Debug.DrawRay(transform.position, transform.TransformDirection( new Vector3(-1,0,1)) * hit2.distance,Color.blue);
		}
			
		RaycastHit hit3;
		if(Physics.Raycast(transform.position,transform.TransformDirection( new Vector3(1,0,1)), out hit3,1000.0f)){
			string objectAimed = hit3.collider.name;
			float distance = hit3.distance;
			Debug.DrawRay(transform.position, transform.TransformDirection( new Vector3(1,0,1)) * hit3.distance,Color.green);
		}
			//Debug.Log("running");
		float[] b = service.RunNN(int.Parse( hit1.collider.tag),int.Parse( hit2.collider.tag),int.Parse( hit3.collider.tag),hit );
		if(hit){
				//service.IncreaseFitness();
				hit=false;
			}
		transform.Rotate(new Vector3(0, direction.y + b[0],0));
		transform.Translate(Vector3.forward * (Time.deltaTime* (b[1]*5)));
		//Debug.Log(n);
		//Debug.Log(service.RunNN());
		
	}
	}
}

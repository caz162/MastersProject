using UnityEngine;
using System.Collections;


public class Wander : MonoBehaviour {
	
	int speed =10;
	Vector3 direction;
	Random rand = new Random();
	int randomDirection;
	MyService service;
	int i =0;
	
	// Use this for initialization
	void Start () {
	service = new MyService();
	}
	
	// Update is called once per frame
	void Update () {
		randomDirection = service.Random(rand,10,-10);
		//randomDirection = Random.Range(-10,10);	
		
		//direction.x = direction.x + randomDirection;
		transform.Rotate(new Vector3(0, direction.y + randomDirection,0));
		transform.Translate(Vector3.forward * (Time.deltaTime* speed));
			
	}
	
	void OnGUI(){
		if(GUI.Button(new Rect(0,40,100,100),"Test Service")){
				Debug.Log("Times Clicked " +service.Add(i,1));
			i++;
			}
	}
}

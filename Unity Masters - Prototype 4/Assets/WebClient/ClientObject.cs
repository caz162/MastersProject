using UnityEngine;
using System.Collections;

public class ClientObject : MonoBehaviour {
	
	MyService service;
	int i =0;
	Random r = new Random();
		
		
	// Use this for initialization
	void Start () {
	service = new MyService();

	}
	
	// Update is called once per frame
	void Update () {
		int n = service.Add(i,i);
		i++;
		
		//Debug.Log(n);
		Debug.Log(service.RunNN());
	}
}

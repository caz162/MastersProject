using UnityEngine;
using System.Collections;

public class GenerateObjects : MonoBehaviour {
	
	Transform prefab;
	Random r = new Random();
	
	
	// Use this for initialization
	void Start () {
		prefab = GameObject.Find("Collect").transform;
		Generate(5);
	
	}
	
	void Generate(int num){
		for(int i =0; i<num; i++){
			float x = UnityEngine.Random.Range(-22,22);
			float y = UnityEngine.Random.Range(-22,22);
			Debug.Log("x" +x);
			Debug.Log("y" +y);
			
			Debug.Log("Testing" + prefab.name);

			Transform g = Instantiate(prefab, new Vector3(x,y,0),Quaternion.identity) as Transform;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

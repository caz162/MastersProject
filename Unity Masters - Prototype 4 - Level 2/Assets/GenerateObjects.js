#pragma strict
var amount : int;
var prefab : Transform;
var rand : Random;

function Start () {

}

function Update () {

}

function Generate(){

	var objects = GameObject.FindGameObjectsWithTag("2");
	for(var go : GameObject in objects){
		Destroy(go);
	}
	
	for(var i=0;i<amount;i++){
		var x  = Random.Range(-10,10);
		var y = Random.Range(-22,22);
	 	Instantiate(prefab,Vector3(x,2,y) ,Quaternion.identity);
	 }
}

#pragma strict

StartCoroutine("Do");

var enemy : GameObject;

function Do () {

	while(true){
	
		var randx : int = Random.Range(0,2);
		var randy : int = Random.Range(0,2);
		
		if(randx == 0) randx = -1;
		else randx = 1; 
		
		if(randy == 0) randy = -1;
		else randy = 1; 
		
		var x : int = Random.Range(5*randx,(5+3)*randx);
		var y : int = Random.Range(6*randy,(6+3)*randy);
		GameObject.Instantiate(enemy,new Vector3 ( x, y,0f),Quaternion.identity);
		
		yield WaitForSeconds (0.7);		
	}
	
}

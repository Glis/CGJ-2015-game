#pragma strict

StartCoroutine("Do");

var enemy : GameObject;


function Do () {

	while(true){
		GameObject.Instantiate(enemy,Vector3.zero,Quaternion.identity);
		
		yield WaitForSeconds (2);		
	}
	
}

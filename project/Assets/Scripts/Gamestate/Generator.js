#pragma strict

//StartCoroutine("Do");

var enemy : GameObject;
var mainCamera : Camera;
var maxCoals : int = 25;

function Start(){

	for(var i =0; i<maxCoals; i++){
		var x : int = Random.Range(mainCamera.ScreenToWorldPoint(new Vector3(0.0f,1.0f,1.0f)).x+0.1f, mainCamera.ScreenToWorldPoint(new Vector3(Screen.width,1.0f,1.0f)).x-0.1f);
		var y : int = Random.Range(mainCamera.ScreenToWorldPoint(new Vector3(1.0f,0.0f,1.0f)).y+0.1f, mainCamera.ScreenToWorldPoint(new Vector3(1.0f,Screen.height,1.0f)).y-0.1f);
		GameObject.Instantiate(enemy,new Vector3 (x,y,0f),Quaternion.identity);
	} 
}

//function Do () {
//
//	while(true){
//		
//		for(var i =0; i<maxCoals; i++){
//			var x : int = Random.Range(mainCamera.ScreenToWorldPoint(new Vector3(0.0f,1.0f,1.0f)).x+0.1f, mainCamera.ScreenToWorldPoint(new Vector3(Screen.width,1.0f,1.0f)).x-0.1f);
//			var y : int = Random.Range(mainCamera.ScreenToWorldPoint(new Vector3(1.0f,0.0f,1.0f)).y+0.1f, mainCamera.ScreenToWorldPoint(new Vector3(1.0f,Screen.height,1.0f)).y-0.1f);
//			GameObject.Instantiate(enemy,new Vector3 (x,y,0f),Quaternion.identity);
//		} 
//		
//		yield WaitForSeconds (0.7);		
//	}
//	
//}

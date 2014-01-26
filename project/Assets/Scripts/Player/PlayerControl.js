#pragma strict
var moveUp: KeyCode;
var moveDown: KeyCode;
var moveLeft: KeyCode;
var moveRight: KeyCode;

var speed : float = 2.0f;
var anim : Animator;

// Use this for initialization
function Start () {
	anim = gameObject.GetComponent(Animator) as Animator;
}


function Update () {

	if(Input.GetKey(moveUp)){
		rigidbody2D.velocity.y = speed;
	}else if(Input.GetKey(moveDown)){
		rigidbody2D.velocity.y=speed*-1;
	}else{
		rigidbody2D.velocity.y=0;
	}
	
	if(Input.GetKey(moveLeft)){
		rigidbody2D.velocity.x=speed*-1;
	}else if(Input.GetKey(moveRight)){
		rigidbody2D.velocity.x=speed;
	}else{	
		rigidbody2D.velocity.x=0;
	}
	
	anim.SetFloat ("Speed", Mathf.Abs(rigidbody2D.velocity.magnitude));
	Debug.Log("Magnitude: " + Mathf.Abs(rigidbody2D.velocity.magnitude));
}
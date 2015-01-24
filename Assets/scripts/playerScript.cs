using UnityEngine;
using System.Collections;

public class playerScript : MonoBehaviour {

	public float movementSpeed;
	public float angularSpeed;
	public float angularIncrement;
	public float movementIncrement;


	// Use this for initialization
	void Start () {
		movementSpeed = 10f;
		angularSpeed = 10f;
		angularIncrement = 10f;
		movementIncrement = 10f;

		StartingJump();
	}
	
	// Update is called once per frame
	void Update () {
//		if(rigidbody2D.angularVelocity >= angularSpeed)
//			angularSpeed = rigidbody2D.angularVelocity;
		rigidbody2D.angularVelocity = angularSpeed;
	}

	//Funcion que mueve al personaje inicialmente
	void StartingJump(){
		rigidbody2D.AddForce(Vector2.up * movementSpeed);
	}

	void Bump(){
		angularSpeed += angularIncrement;
		movementSpeed += movementIncrement;
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Object") {
			print ("ouch Object");
			rigidbody2D.velocity = coll.relativeVelocity *-1.0f;
//			rigidbody2D.angularVelocity = angularSpeed;
			Bump();
		}

		if (coll.gameObject.tag == "Boundaries") {
			print ("ouch Boundaries");	
			if(coll.gameObject.name == "leftwall"){
				rigidbody2D.AddForce(new Vector2(1.0f,rigidbody2D.velocity.y)*movementSpeed);
			}else if(coll.gameObject.name == "rightwall"){
				rigidbody2D.AddForce(new Vector2(-1.0f,rigidbody2D.velocity.y)*movementSpeed);
			}else if(coll.gameObject.name == "roof"){
				rigidbody2D.AddForce(new Vector2(rigidbody2D.velocity.x,-1.0f)*movementSpeed);
			}else if(coll.gameObject.name == "floor"){
				rigidbody2D.AddForce(new Vector2(rigidbody2D.velocity.x,1.0f)*movementSpeed);
			}
			Bump();
		}
//			coll.gameObject.SendMessage("ApplyDamage", 10);
	}
}

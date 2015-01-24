using UnityEngine;
using System.Collections;

public class playerScript : MonoBehaviour {

	//Transforms
	public Transform fan;

	public float movementSpeed;
	public float angularSpeed;
	public float angularIncrement;
	public float movementPush;
	private Vector2 la_normal;
	private Vector2 colPoint;

	// Use this for initialization
	void Start () {
		movementSpeed = 0.1f;
		angularSpeed = 40f;
		angularIncrement = 50f;
		movementPush = 1.3f;

		StartingJump();
	}
	
	// Update is called once per frame
	void Update () {
		print ("veloc"+rigidbody2D.velocity );
		if (Input.GetKeyDown("space")) {
			movementSpeed = rigidbody2D.velocity.magnitude + movementSpeed;
			rigidbody2D.velocity += ((Vector2)(fan.position-transform.position)) *(-1)* movementPush;
		}
//		if(rigidbody2D.angularVelocity >= angularSpeed)
//			angularSpeed = rigidbody2D.angularVelocity;
		rigidbody2D.angularVelocity = angularSpeed;
	}

	//Funcion que mueve al personaje inicialmente
	void StartingJump(){
//		rigidbody2D.AddForce(Vector2.up * movementSpeed);
		rigidbody2D.velocity += Vector2.up * 0.1f;

	}

	void Bump(){
		if (angularSpeed >= 500) {
			angularSpeed = 500;
		} else if (angularSpeed <= -500){
			angularSpeed = -500;
		} else {
			angularSpeed = Mathf.Abs (angularSpeed) + angularIncrement;
			angularSpeed = angularSpeed * -1;
		}
	}

	void OnCollisionEnter2D(Collision2D coll) {
		la_normal = coll.contacts [0].normal;
		colPoint = coll.contacts [0].point;
		if (coll.gameObject.tag == "Object") {
			print ("ouch Object");
//			rigidbody2D.velocity = coll.contacts [0].normal.normalized * movementSpeed;
//			rigidbody2D.angularVelocity = angularSpeed;
			Bump();
		}

		if (coll.gameObject.tag == "Boundaries") {
			print ("ouch Boundaries"+rigidbody2D.velocity );
//			print ();

//			if(coll.gameObject.name == "leftwall"){
//				rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x * -1,rigidbody2D.velocity.y);
////				rigidbody2D.velocity = new Vector2(1.0f,rigidbody2D.velocity.normalized.y) * movementSpeed /** rigidbody2D.velocity.magnitude*/;
////				rigidbody2D.AddForce(new Vector2(1.0f,rigidbody2D.velocity.y)*movementSpeed);
//			}else if(coll.gameObject.name == "rightwall"){
//				rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x * -1,rigidbody2D.velocity.y);
////				rigidbody2D.velocity = new Vector2(-1.0f,rigidbody2D.velocity.normalized.y) * movementSpeed /** rigidbody2D.velocity.magnitude*/;
////				rigidbody2D.AddForce(new Vector2(-1.0f,rigidbody2D.velocity.y)*movementSpeed);
//			}else if(coll.gameObject.name == "roof"){
//				rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, rigidbody2D.velocity.y * -1);
////				rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.normalized.x,-1.0f) * movementSpeed /** rigidbody2D.velocity.magnitude*/;
////				rigidbody2D.AddForce(new Vector2(rigidbody2D.velocity.x,-1.0f)*movementSpeed);
//			}else if(coll.gameObject.name == "floor"){
//				rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, rigidbody2D.velocity.y * -1);
////				rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.normalized.x,1.0f) * movementSpeed /** rigidbody2D.velocity.magnitude*/;
////				rigidbody2D.AddForce(new Vector2(rigidbody2D.velocity.x,1.0f)*movementSpeed);
//			}
			Bump();
		}
//			coll.gameObject.SendMessage("ApplyDamage", 10);
	}

	void OnDrawGizmos(){
//		Gizmos.color = Color.green;
//		Gizmos.DrawLine(colPoint, colPoint + la_normal);

	}
}

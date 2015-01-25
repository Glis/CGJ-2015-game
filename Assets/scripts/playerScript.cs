using UnityEngine;
using System.Collections;

public class playerScript : MonoBehaviour {

	//Transforms
	public Transform fan;

	//Consts
	private const float MAX_MOV_SPEED = 0.8f;
	private const float MAX_ANG_SPEED = 550.0f;
	private const float INITIAL_FORCE = 2f;
	private const float INITIAL_TORQUE = 2f;

	//Vars
	public float movementSpeed;
	public float angularSpeed;
	public float angularIncrement;
	public float movementPush;
	public float movementForce;
	private Vector2 la_normal;
	private Vector2 colPoint;

	//counters & Flags(life)
	public int bumpCounter = 0;
	public bool positive = true;

	//sound effects
	public AudioSource collisionSound;

	// Use this for initialization
	void Start () {
		movementSpeed = 0.1f;
		angularSpeed = 40f;
		angularIncrement = 50f;
		movementPush = 1.3f;
		movementForce = 50f;

		StartingJump();
	}
	
	// Update is called once per frame
	void Update () {
		//print ("veloc"+rigidbody2D.velocity );
		if (Input.GetKeyDown("space")) {
			//print("pressed Space");
			movementSpeed = rigidbody2D.velocity.magnitude + movementSpeed;
			moveInADirection((Vector2)(fan.position-transform.position) *-1);
//			rigidbody2D.velocity += ((Vector2)(fan.position-transform.position)) *(-1)* movementPush;
		}
	}

	//Funcion que mueve al personaje inicialmente
	void StartingJump(){
		rigidbody2D.AddForce(Vector2.up * INITIAL_FORCE);
		rigidbody2D.AddTorque(INITIAL_TORQUE);
		//manual movement
//		rigidbody2D.velocity += Vector2.up * 0.1f;

	}

	void Bump(Vector2 directionOfBump){
		collisionSound.Play();
		if (bumpCounter < 20) {
			bumpCounter++;
			print("BUMP!");
		}else if(bumpCounter == 20){
			print ("PERDISTE SAPO");
		}
		spinInADirection(!positive);
		moveInADirection (directionOfBump);
	}

	void spinInADirection (bool pos){
		if (rigidbody2D.angularVelocity >= MAX_ANG_SPEED) {
			rigidbody2D.angularVelocity = MAX_ANG_SPEED;
		} else if (rigidbody2D.angularVelocity <= -MAX_ANG_SPEED){
			rigidbody2D.angularVelocity = -MAX_ANG_SPEED;
		} else {
			rigidbody2D.angularVelocity = Mathf.Abs (rigidbody2D.angularVelocity) + angularIncrement;
			if(!pos)
				rigidbody2D.angularVelocity = rigidbody2D.angularVelocity * -1;
		}
//		if (angularSpeed >= MAX_ANG_SPEED) {
//			angularSpeed = MAX_ANG_SPEED;
//		} else if (angularSpeed <= -MAX_ANG_SPEED){
//			angularSpeed = -MAX_ANG_SPEED;
//		} else {
//			angularSpeed = Mathf.Abs (angularSpeed) + angularIncrement;
//			if(!pos)
//				angularSpeed = angularSpeed * -1;
//		}
	}

 	void moveInADirection(Vector2 dir){
		if (rigidbody2D.velocity.magnitude >= MAX_MOV_SPEED) {
			rigidbody2D.AddForce(dir * movementForce);
			rigidbody2D.velocity = rigidbody2D.velocity.normalized * MAX_MOV_SPEED;
		} else {
			rigidbody2D.AddForce(dir * movementForce);
		}
	}

	void OnCollisionEnter2D(Collision2D coll) {
		la_normal = coll.contacts [0].normal;
		la_normal.Normalize();
		
		colPoint = coll.contacts [0].point;
		if (coll.gameObject.tag == "Object") {
			print ("ouch Object");
			//Calculating the direction of themovement
			
//			rigidbody2D.velocity = coll.contacts [0].normal.normalized * movementSpeed;
//			rigidbody2D.AddForce(la_normal.normalized) * movementSpeed;
////			rigidbody2D.angularVelocity = angularSpeed;
			Bump(la_normal);
		}

		if (coll.gameObject.tag == "Boundaries") {
			print ("ouch Boundaries"+la_normal );
//			print ();

//			if(coll.gameObject.name == "leftwall"){
////				rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x * -1,rigidbody2D.velocity.y);
////				rigidbody2D.velocity = new Vector2(1.0f,rigidbody2D.velocity.normalized.y) * movementSpeed /** rigidbody2D.velocity.magnitude*/;
//				rigidbody2D.AddForce(new Vector2(1.0f,rigidbody2D.velocity.y)*movementSpeed);
//			}else if(coll.gameObject.name == "rightwall"){
////				rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x * -1,rigidbody2D.velocity.y);
////				rigidbody2D.velocity = new Vector2(-1.0f,rigidbody2D.velocity.normalized.y) * movementSpeed /** rigidbody2D.velocity.magnitude*/;
//				rigidbody2D.AddForce(new Vector2(-1.0f,rigidbody2D.velocity.y)*movementSpeed);
//			}else if(coll.gameObject.name == "roof"){
////				rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, rigidbody2D.velocity.y * -1);
////				rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.normalized.x,-1.0f) * movementSpeed /** rigidbody2D.velocity.magnitude*/;
//				rigidbody2D.AddForce(new Vector2(rigidbody2D.velocity.x,-1.0f)*movementSpeed);
//			}else if(coll.gameObject.name == "floor"){
////				rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, rigidbody2D.velocity.y * -1);
////				rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.normalized.x,1.0f) * movementSpeed /** rigidbody2D.velocity.magnitude*/;
//				rigidbody2D.AddForce(new Vector2(rigidbody2D.velocity.x,1.0f)*movementSpeed);
//			}
			if(coll.gameObject.name == "leftwall" || coll.gameObject.name == "rightwall"){
				Bump(new Vector2(la_normal.x,rigidbody2D.velocity.y));
			}else if(coll.gameObject.name == "roof" || coll.gameObject.name == "floor"){
				Bump(new Vector2(rigidbody2D.velocity.x,la_normal.y));
			}
		}
				    
//			coll.gameObject.SendMessage("ApplyDamage", 10);
	}

	void OnDrawGizmos(){
//		Gizmos.color = Color.green;
//		Gizmos.DrawLine(colPoint, colPoint + la_normal);

	}
}

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
	public bool rotationIsPositive = true;

	//sound effects
	public AudioSource collisionSound;

	private GameState gamestate;

	// Use this for initialization
	void Start () {
		gamestate = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameState> ();

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
			if(!gamestate.levelFinished){
				movementSpeed = rigidbody2D.velocity.magnitude + movementSpeed;
				moveInADirection((Vector2)(fan.position-transform.position) *-1);
	//			rigidbody2D.velocity += ((Vector2)(fan.position-transform.position)) *(-1)* movementPush;
			}
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
		if(!gamestate.levelFinished){
			if (bumpCounter < 20) {
				bumpCounter++;
				print("BUMP!"+bumpCounter);
			}else if(bumpCounter == 20){
				print ("PERDISTE SAPO");
			}
			spinInADirection(!rotationIsPositive);
				moveInADirection (directionOfBump);
		}
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
			Bump(la_normal);
		}

		if (coll.gameObject.tag == "Boundaries") {
			print ("ouch Boundaries"+la_normal );

			if(coll.gameObject.name == "leftwall" || coll.gameObject.name == "rightwall"){
				Bump(new Vector2(la_normal.x,rigidbody2D.velocity.y));
			}else if(coll.gameObject.name == "roof" || coll.gameObject.name == "floor"){
				Bump(new Vector2(rigidbody2D.velocity.x,la_normal.y));
			}
		}
				    
//			coll.gameObject.SendMessage("ApplyDamage", 10);
	}

	void OnTriggerEnter2D(Collider2D other) {
		print ("GRAVEDAD RESTAURADA!!!");
		Destroy (other.gameObject);
		//Cambiar el sprite del jugador por un sprite con la herramienta

		rigidbody2D.gravityScale = 1;
		rigidbody2D.angularDrag = 0.8f;
		rigidbody2D.drag = 0.1f;

		foreach (GameObject g in GameObject.FindGameObjectsWithTag("Object")) {
			g.rigidbody2D.gravityScale = 1;
			g.rigidbody2D.drag = 0.1f;
		}

		gamestate.levelFinished = true;
	}


	void OnDrawGizmos(){
//		Gizmos.color = Color.green;
//		Gizmos.DrawLine(colPoint, colPoint + la_normal);

	}
}

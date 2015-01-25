using UnityEngine;
using System.Collections;

public class CharacterDeadScript : MonoBehaviour 
{
	private const float MAX_MOV_SPEED = 0.8f;
	private const float MAX_ANG_SPEED = 550.0f;

	public Transform player;
	public GameObject body;
	public GameObject fan;

	// Use this for initialization
	void Start () 
	{
		transform.position = player.position;
		body.rigidbody2D.AddForce(Vector2.right * Random.Range(-3f,3f));
		body.rigidbody2D.AddTorque(Random.Range(-3f,3f));
		
		fan.rigidbody2D.AddForce(Vector2.right * Random.Range(-3f,3f));
		fan.rigidbody2D.AddTorque(Random.Range(-3f,3f));
	}
	
	void FixedUpdate()
	{
		if (body.rigidbody2D.angularVelocity >= MAX_ANG_SPEED) {
			body.rigidbody2D.angularVelocity = MAX_ANG_SPEED;
		} else if (body.rigidbody2D.angularVelocity <= -MAX_ANG_SPEED){
			body.rigidbody2D.angularVelocity = -MAX_ANG_SPEED;
		}
		
		if (fan.rigidbody2D.angularVelocity >= MAX_ANG_SPEED) {
			fan.rigidbody2D.angularVelocity = MAX_ANG_SPEED;
		} else if (fan.rigidbody2D.angularVelocity <= -MAX_ANG_SPEED){
			fan.rigidbody2D.angularVelocity = -MAX_ANG_SPEED;
		}
	}
}
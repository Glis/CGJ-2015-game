using UnityEngine;
using System.Collections;

public class nyan_force : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//rigidbody2D.AddForce(Vector2.up * 0.5F);
		rigidbody2D.AddForce(Vector2.right * -100f);
		//rigidbody2D.AddTorque (Random.Range(-0.2F, 0.2F));

	}

	public float maxSpeed = 100f;//Replace with your max speed

	// Update is called once per frame
	void Update () {
		if(rigidbody2D.velocity.magnitude > maxSpeed)
		{
			rigidbody2D.velocity = rigidbody2D.velocity.normalized * maxSpeed;
		}
	}
}

using UnityEngine;
using System.Collections;

public class force : MonoBehaviour {

	public AudioSource scream;

	// Use this for initialization
	void Start () {
		rigidbody2D.AddForce(Vector2.up * Random.Range(1.0F, 4.0F));
		rigidbody2D.AddForce(Vector2.right * Random.Range(-4.0F, 4.0F));
		rigidbody2D.AddTorque (Random.Range(-0.5F, 0.5F));
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D coll){
		if (scream != null) {
			scream.Play ();
		}
	}
}

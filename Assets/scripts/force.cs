using UnityEngine;
using System.Collections;

public class force : MonoBehaviour {

	public AudioSource scream;

	// Use this for initialization
	void Start () {
		rigidbody2D.AddForce((new Vector2(Random.Range(1.0F, -1.0F),Random.Range(1.0F, 0.5f)))* Random.Range(2.0F, 7.0F));
		rigidbody2D.AddTorque(Random.Range(-1.3F, 1.3F));
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

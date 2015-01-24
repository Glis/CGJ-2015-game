using UnityEngine;
using System.Collections;

public class force : MonoBehaviour {

	// Use this for initialization
	void Start () {
		rigidbody2D.AddForce(Vector2.up * 5);
		rigidbody2D.AddForce(Vector2.right );
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

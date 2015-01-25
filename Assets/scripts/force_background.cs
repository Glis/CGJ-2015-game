using UnityEngine;
using System.Collections;

public class force_background : MonoBehaviour {
	public float upFactor = 0.5F;
	// Use this for initialization
	void Start () {
		rigidbody2D.AddForce(Vector2.up * upFactor);
		rigidbody2D.AddForce(Vector2.right * Random.Range(-upFactor, upFactor));
		rigidbody2D.AddTorque (Random.Range(-upFactor/2, upFactor/2));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

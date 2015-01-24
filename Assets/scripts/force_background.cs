using UnityEngine;
using System.Collections;

public class force_background : MonoBehaviour {
	public float upFactor = 0.5F;
	// Use this for initialization
	void Start () {
		rigidbody2D.AddForce(Vector2.up * 0.5F);
		rigidbody2D.AddForce(Vector2.right * Random.Range(-0.3F, 0.3F));
		rigidbody2D.AddTorque (Random.Range(-0.2F, 0.2F));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

using UnityEngine;
using System.Collections;

public class playerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		rigidbody2D.AddTorque (Random.Range(-0.5F, 0.5F));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

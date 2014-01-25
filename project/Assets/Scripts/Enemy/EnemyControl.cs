using UnityEngine;
using System.Collections;

public class EnemyControl : MonoBehaviour {

	private Transform Target;
	private float speed = 3.0f;
	// Use this for initialization
	void Start () {
		Target = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 director = (Target.position - transform.position).normalized;
		rigidbody2D.velocity = speed * director;
	}
}

using UnityEngine;
using System.Collections;

public class EnemyControl : MonoBehaviour {

	private Vector3 Target;
	private float speed = 3.0f;
	// Use this for initialization
	void Start () {
		StartCoroutine("random_target");
	}

	IEnumerator random_target () {
		while(true)
		{
			Target = new Vector3(Random.Range(-20,20),Random.Range(-20,20),0f);
			yield return new WaitForSeconds(2f);
		}
	}

	// Update is called once per frame
	void Update () {
		Vector3 director = (Target - transform.position).normalized;
		rigidbody2D.velocity = speed * director;
	}
}

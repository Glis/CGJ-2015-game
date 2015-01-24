using UnityEngine;
using System.Collections;

public class EnemyControl : MonoBehaviour {

	private Vector3 Target;
	public float Speed = 3.0f;
	public Animator anim;

	// Use this for initialization
	void Start () {
		StartCoroutine("random_target");
		anim = gameObject.GetComponent<Animator>();	
	}

	IEnumerator random_target () {
		while(true)
		{
			Target = new Vector3(Random.Range(-20,20),Random.Range(-20,20),0f);
			yield return new WaitForSeconds(Random.Range(1,3));
		}
	}

	// Update is called once per frame
	void Update () {

		Vector3 director = (Target - transform.position).normalized;
		rigidbody2D.velocity = Speed * director;
		if (director.y > 0)anim.SetBool ("Back", true);
		else anim.SetBool ("Back", false);
//		print(rigidbody2D.velocity.ToString());
		anim.SetFloat ("Speed", Mathf.Abs(rigidbody2D.velocity.magnitude));

	}
}

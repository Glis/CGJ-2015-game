using UnityEngine;
using System.Collections;

public class LeftToRight : MonoBehaviour {

	public float speed = 1.0f;
	public string axisName = "Horizontal";
	public Animator anim;
	// Use this for initialization
	void Start () {
		anim = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		anim.SetFloat ("Speed", Mathf.Abs(Input.GetAxis(axisName)));
		transform.position += transform.right * Input.GetAxis(axisName) * speed * Time.deltaTime;
	}
}

using UnityEngine;
using System.Collections;

public class PointerScript : MonoBehaviour {

	private Transform machine;

	// Use this for initialization
	void Start () 
	{
		machine = GameObject.FindWithTag("Goal").transform;
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.LookAt(machine);
		transform.Rotate(new Vector3(0, 90, 90));
	}
}

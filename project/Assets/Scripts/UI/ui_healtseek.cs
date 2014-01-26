using UnityEngine;
using System.Collections;

public class ui_healtseek : MonoBehaviour {

	public Vector3 offset;
	public GameObject Target;
	private Transform player;
	// Use this for initialization
	void Awake()
	{

		player = Target.transform;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = player.position + offset;
	}
}

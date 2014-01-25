using UnityEngine;
using System.Collections;

public class ConeShadowingHandler : MonoBehaviour {

	public GameObject papito;
	public Transform player;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 distancia = transform.position - player.position;
//		int dist = distancia.magnitude;
//		if(dist < 1){
			float delta = Mathf.Acos(Vector3.Dot(Vector3.up, distancia.normalized));
		float side = player.position.x < transform.position.x ? -1 : 1;
			//print(delta);
			transform.rotation = Quaternion.Euler(new Vector3(0,0,delta*side*Mathf.Rad2Deg));
//		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject != papito){
//			print("TRIGGER!!!!!");
			if (other.gameObject.CompareTag("Enemy")){
//				print("TAG-TRIGGER!!!!!"+other.name+"-layer"+other.gameObject.layer);
				GameObject.Destroy(other.gameObject,1);
			}
		}
	}
}

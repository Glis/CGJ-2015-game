using UnityEngine;
using System.Collections;

public class ConeShadowingHandler : MonoBehaviour {

	public GameObject papito;
	private Transform player;
	public float Distancia = 5f;
	public SpriteRenderer coneRenderer;
	public BoxCollider2D coneCollider;
	public KeyCode trigger;
	public Gamestate gamestate;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player1").transform;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 distancia = transform.position - player.position;
		float dist = distancia.magnitude;
		if(dist < Distancia){
			if(!coneRenderer.enabled){
				coneRenderer.enabled = true;
				coneCollider.enabled = true;
			}
			float delta = Mathf.Acos(Vector3.Dot(Vector3.up, distancia.normalized));
		    float side = player.position.x < transform.position.x ? -1 : 1;
			//print(delta);
			transform.localScale = new Vector3(1,2/dist,1);
			transform.rotation = Quaternion.Euler(new Vector3(0,0,delta*side*Mathf.Rad2Deg));
		}else{
			if(coneRenderer.enabled){
				coneRenderer.enabled = false;
				coneCollider.enabled = false;
			}
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject != papito){
			if (other.gameObject.CompareTag("Player2") && Input.GetKeyDown(trigger)){
				print("TAG-TRIGGER!!!!!"+other.name+"-layer"+other.gameObject.layer);
				gamestate.player1Runner=true;
				//				StartCoroutine("destroyFriend");
			}
		}
	}

	void OnTriggerExit2D(Collider2D other){
		if(other.gameObject != papito){
			if (other.gameObject.CompareTag("Enemy")){
				//				print("TAG-TRIGGER!!!!!"+other.name+"-layer"+other.gameObject.layer);
//				StopCoroutine("destroyFriend");
			}
		}
	}

//	IEnumerator destroyFriend(GameObject other){
//		yield return new WaitForSeconds(1);
//		GameObject.Destroy(other,1);
//	}
}

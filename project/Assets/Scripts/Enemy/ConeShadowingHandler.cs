using UnityEngine;
using System.Collections;

public class ConeShadowingHandler : MonoBehaviour {

	public GameObject papito;
	private Transform player;
	public float DistanciaEntreB;
	public SpriteRenderer coneRenderer;
	public BoxCollider2D coneCollider;
	public KeyCode triggerPlayer1;
	public KeyCode triggerPlayer2;
	private Gamestate gamestate;
	public float maxlength;
	public Animator anim;

	// Use this for initialization
	void Start () {
		gamestate = GameObject.Find("GameSetup").GetComponent<Gamestate>();
		maxlength = 1.5f;
		DistanciaEntreB = 3.0f;
		anim = papito.GetComponent<Animator>();	
	}
	
	// Update is called once per frame
	void Update () {
		if (gamestate.player1Runner) {
			player = GameObject.FindGameObjectWithTag ("Player1").transform;				
		}else{
			player = GameObject.FindGameObjectWithTag ("Player2").transform;
		}
		Vector3 distancia = transform.position - player.position;
		float dist = distancia.magnitude;
		if (dist < DistanciaEntreB) {
			if (!coneRenderer.enabled) {
				coneRenderer.enabled = true;
				coneCollider.enabled = true;
				anim.SetBool ("Electrified", coneCollider.enabled);
			}
			float delta = Mathf.Acos (Vector3.Dot (Vector3.up, distancia.normalized));
			float side = player.position.x < transform.position.x ? -1 : 1;
			transform.rotation = Quaternion.Euler (new Vector3 (0, 0, delta * side * Mathf.Rad2Deg));

			float shadLength = ( 2f / dist ) > maxlength ? maxlength: ( 2f / dist ); 
			if (shadLength < 0.2f)
				shadLength = 0.2f;
			transform.localScale = new Vector3 (1.0f, shadLength , 1.0f);

		} else {
			if (coneRenderer.enabled) {
				coneRenderer.enabled = false;
				coneCollider.enabled = false;
				anim.SetBool ("Electrified", coneCollider.enabled);
			}
		}	
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject != papito){

			if (other.gameObject.CompareTag("Player2") && Input.GetKeyDown(triggerPlayer2)){
				gamestate.setPlayerRunner(false);
				GameObject.Destroy(papito);
				gamestate.setPlayer2Points(5f);
			}

			if (other.gameObject.CompareTag("Player1") && Input.GetKeyDown(triggerPlayer1)){
				gamestate.setPlayerRunner(true);
				GameObject.Destroy(papito);
				gamestate.setPlayer1Points(5f);
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

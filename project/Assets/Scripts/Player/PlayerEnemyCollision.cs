using UnityEngine;
using System.Collections;

public class PlayerEnemyCollision : MonoBehaviour {

	private double lastIntervalEnemy;
	private double updateInterval=0.5;
	public AudioSource bump;
	// Use this for initialization
	void Start () {	
		lastIntervalEnemy = Time.realtimeSinceStartup;
	}

	void OnCollisionEnter2D(Collision2D collision){
	
		if(collision.collider.tag.Equals("Enemy")){
			double currentTime=Time.realtimeSinceStartup;
			if(currentTime > lastIntervalEnemy + updateInterval){
//				Debug.Log("enemy");
				bump.Play();
				lastIntervalEnemy=currentTime;
			}
		}

	}

	// Update is called once per frame
	void Update () {
	
	}
}

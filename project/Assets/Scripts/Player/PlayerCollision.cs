using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour {
	
	public GameObject otherPlayer;
	private double lastIntervalPlayer;
	private double updateInterval=0.5;
	// Use this for initialization
	void Start () {	
		lastIntervalPlayer = Time.realtimeSinceStartup;
	}
	
	void OnCollisionEnter2D(Collision2D collision){
		
		if(collision.collider.tag.Equals(otherPlayer.tag)){
			double currentTime=Time.realtimeSinceStartup;
			if(currentTime > lastIntervalPlayer + updateInterval){
				Debug.Log("other player");
				lastIntervalPlayer=currentTime;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

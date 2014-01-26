using UnityEngine;
using System.Collections;

public class Gamestate : MonoBehaviour {

	private const int MAX_LIGHT = 100;
	public bool player1Runner;
	public float player1points;
	public float player2points;

	// Use this for initialization
	void Start () {
		player1Runner = true;
		player1points = 0.0f;
		player2points = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if(player1Runner){
			player1points+=Time.deltaTime;
			player2points-=0.5f*Time.deltaTime;
		}else{
			player2points+=Time.deltaTime;
			player1points-=0.5f*Time.deltaTime;
		}

		//Win condition!
		if(player1points>=MAX_LIGHT)
			player1Wins(true);
		if(player2points>=MAX_LIGHT)
			player1Wins(false);

		print (player1Runner);
		/*if(Input.GetKeyDown(KeyCode.Space)){
			player1Runner= !player1Runner;
		}*/
	}

	public void togglePlayerRunner(){
		player1Runner = !player1Runner;
	}

	void player1Wins(bool player1){
		if(player1){
			print ("HA GANADO EL JUGADOR 1!");
		}else{
			print ("HA GANADO EL JUGADOR 2!");
		}
	}
}

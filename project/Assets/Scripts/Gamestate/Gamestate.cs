using UnityEngine;
using System.Collections;

public class Gamestate : MonoBehaviour {

	public const int MAX_LIGHT = 100;
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
		if (player2points > 0)
				player2points = 0;
						
		if (player1points < 0)
			player1points = 0;

		if (player2points < 0)
			player2points = 0;

		//Win condition!
		if(player1points>=MAX_LIGHT)
			player1Wins(true);
		if(player2points>=MAX_LIGHT)
			player1Wins(false);	

//		print ("Player1: " + player1points);
//		print ("Player2: " + player2points);
	}

	public void setPlayer1Points(float points){
		player1points += points;
	}

	public void setPlayer2Points(float points){
		player2points += points;
	}


	public void setPlayerRunner(bool flagPlayer){
		player1Runner = flagPlayer;
	}

	void player1Wins(bool player1){
		if(player1){
			print ("HA GANADO EL JUGADOR 1!");
		}else{
			print ("HA GANADO EL JUGADOR 2!");
		}
	}
}

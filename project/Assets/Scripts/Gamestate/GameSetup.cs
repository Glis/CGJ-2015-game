using UnityEngine;
using System.Collections;

public class GameSetup : MonoBehaviour {

	public Camera mainCamera;

	public BoxCollider2D top;
	public BoxCollider2D bottom;
	public BoxCollider2D left;
	public BoxCollider2D right;
	
	public Gamestate state;
	
	public GUISkin GUIMenuPrincipal;

	private Transform r1,r2,r3,r4,r5,r6,r7,r8,r9,r10,r01,r02;

	void Start()
	{
		state = GetComponent<Gamestate>();

		r01 = GameObject.Find("p1").GetComponent<SpriteRenderer>().transform;
		r02 = GameObject.Find("p2").GetComponent<SpriteRenderer>().transform;

		r1 = GameObject.Find("first1").GetComponent<SpriteRenderer>().transform;
		r2 = GameObject.Find("first2").GetComponent<SpriteRenderer>().transform;
		r3 = GameObject.Find("first3").GetComponent<SpriteRenderer>().transform;
		r4 = GameObject.Find("first4").GetComponent<SpriteRenderer>().transform;
		r5 = GameObject.Find("first5").GetComponent<SpriteRenderer>().transform;
		r6 = GameObject.Find("first6").GetComponent<SpriteRenderer>().transform;
		r7 = GameObject.Find("first7").GetComponent<SpriteRenderer>().transform;
		r8 = GameObject.Find("first8").GetComponent<SpriteRenderer>().transform;
		r9 = GameObject.Find("first9").GetComponent<SpriteRenderer>().transform;
		r10 = GameObject.Find("first10").GetComponent<SpriteRenderer>().transform;
				
	}
	
	// Update is called once per frame
	void Update () {
		top.size = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(Screen.width*2f, 0f, 0f)).x, 1f);
		top.center = new Vector2(0f, mainCamera.ScreenToWorldPoint(new Vector3(0f, Screen.height, 0f)).y + 0.5f);
		
		bottom.size = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(Screen.width*2f, 0f, 0f)).x, 1f);
		bottom.center = new Vector2(0f, mainCamera.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).y - 0.5f);
		
		left.size = new Vector2(1f, mainCamera.ScreenToWorldPoint(new Vector3(0f, Screen.height*2f, 0f)).y);
		left.center = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x - 0.5f, 0f);
		
		right.size = new Vector2(1f, mainCamera.ScreenToWorldPoint(new Vector3(0f, Screen.height*2f, 0f)).y);
		right.center = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x + 0.5f, 0f);
	
		r1.position = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x + 0.5f, 0f);
		r2.position = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x + 0.5f, 0.50f);
		r3.position = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x + 0.5f, 1f);
		r4.position = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x + 0.5f, 1.50f);
		r5.position = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x + 0.5f, 2f);
		r01.position = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x + 0.5f, 2.50f);

		r6.position = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x - 0.5f, 0f);
		r7.position = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x - 0.5f, 0.50f);
		r8.position = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x - 0.5f, 1f);
		r9.position = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x - 0.5f, 1.50f);
		r10.position = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x - 0.5f, 2f);
		r02.position = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x - 0.5f, 2.50f);

	}

	void OnGUI(){
		
		GUI.skin = GUIMenuPrincipal;
	
		if(state.GameOver){
			GUI.Label(new Rect(0,0,Screen.width/2,(Screen.height)/2),"HA GANADO EL JUGADOR 1!");
			if(GUI.Button(new Rect(0,0,Screen.width/2,((Screen.height)*2)/3),"MAIN MENU")){
				Application.LoadLevel("MainMenu");
			}
		}
	}
}


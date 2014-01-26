using UnityEngine;
using System.Collections;

public class ui_barscore : MonoBehaviour {

	private Gamestate estado;
	public GUISkin GUIMenuPrincipal;
	public Sprite sprite1;
	public Sprite sprite2;
	public Sprite sprite3;

	private SpriteRenderer r1,r2,r3,r4,r5,r6,r7,r8,r9,r10;

	float W;
	float H;
	// Use this for initialization
	void Start()
	{
		W=Screen.width;
		H=Screen.height;
		estado = GameObject.Find("GameSetup").GetComponent<Gamestate>();
		r1 = GameObject.Find("first1").GetComponent<SpriteRenderer>();
		r2 = GameObject.Find("first2").GetComponent<SpriteRenderer>();
		r3 = GameObject.Find("first3").GetComponent<SpriteRenderer>();
		r4 = GameObject.Find("first4").GetComponent<SpriteRenderer>();
		r5 = GameObject.Find("first5").GetComponent<SpriteRenderer>();
		r6 = GameObject.Find("first6").GetComponent<SpriteRenderer>();
		r7 = GameObject.Find("first7").GetComponent<SpriteRenderer>();
		r8 = GameObject.Find("first8").GetComponent<SpriteRenderer>();
		r9 = GameObject.Find("first9").GetComponent<SpriteRenderer>();
		r10 = GameObject.Find("first10").GetComponent<SpriteRenderer>();


	}
	
	// Update is called once per frame
	void Update () 
	{
		// 5 estados de 3 intervalos 
		float puntos1 = estado.player1points; // 100% para jugador 1
		float puntos2 = estado.player2points;
		int p1 = Gamestate.MAX_LIGHT;
		float porcentaje1 = Mathf.FloorToInt((puntos1*100f) /(float)p1);
		float porcentaje2 = Mathf.FloorToInt((puntos2*100f) /(float)p1);
		Debug.Log(porcentaje1);
		Debug.Log(porcentaje2);
		if(porcentaje1 < 20) // 0% - 20%
		{
			if(porcentaje1 >= 0 && porcentaje1 < 7)	{
				r1.sprite = sprite1;
			}
			if(porcentaje1 >= 7 && porcentaje1 < 13){
				r1.sprite = sprite2;
			}
			if(porcentaje1 >= 14 && porcentaje1 < 20){
				r1.sprite = sprite3;
			}
		}	
		if(porcentaje1 < 40) // 20% - 40%
		{	
			//3 condiciones
			if(porcentaje1 >= 21 && porcentaje1 < 28){
				r2.sprite = sprite1;}
			if(porcentaje1 >= 29 && porcentaje1 < 35){
				r2.sprite = sprite2;}
			if(porcentaje1 >= 36 && porcentaje1 < 40){
				r2.sprite = sprite3;}
		}	
		if(porcentaje1 < 60) // 40% - 60%
		{	
			//3 condiciones
			if(porcentaje1 >= 41 && porcentaje1 < 47){
				r3.sprite = sprite1;}
			if(porcentaje1 >= 48 && porcentaje1 < 55){
				r3.sprite = sprite2;}
			if(porcentaje1 >= 56 && porcentaje1 < 60){
				r3.sprite = sprite3;}
		}	
		if(porcentaje1 < 80) // 60% - 80%
		{	
			//3 condiciones
			if(porcentaje1 >= 61 && porcentaje1 < 67){
				r4.sprite = sprite1;}
			if(porcentaje1 >= 68 && porcentaje1 < 74){
				r4.sprite = sprite2;}
			if(porcentaje1 >= 75 && porcentaje1 < 80){
				r4.sprite = sprite3;}
		}	
		if(porcentaje1 <= 100) // 80% - 100%
		{	
			//3 condiciones
			if(porcentaje1 >= 81 && porcentaje1 < 86){
				r5.sprite = sprite1;}
			if(porcentaje1 >= 87 && porcentaje1 < 94){
				r5.sprite = sprite2;}
			if(porcentaje1 >= 100){
				r5.sprite = sprite3;}
		}	

		//player 2
		if(porcentaje2 < 20) // 0% - 20%
		{
			if(porcentaje2 >= 0 && porcentaje2 < 7){
				r6.sprite = sprite1;}
			if(porcentaje2 >= 7 && porcentaje2 < 13){
				r6.sprite = sprite2;}
			if(porcentaje2 >= 14 && porcentaje2 < 20){
				r6.sprite = sprite3;}
		}	
		if(porcentaje2 < 40) // 20% - 40%
		{	
			//3 condiciones
			if(porcentaje2 >= 21 && porcentaje2 < 28){
				r7.sprite = sprite1;}
			if(porcentaje2 >= 29 && porcentaje2 < 35){
				r7.sprite = sprite2;}
			if(porcentaje2 >= 36 && porcentaje2 < 40){
				r7.sprite = sprite3;}
		}	
		if(porcentaje2 < 60) // 40% - 60%
		{	
			//3 condiciones
			if(porcentaje2 >= 41 && porcentaje2 < 47){
				r8.sprite = sprite1;}
			if(porcentaje2 >= 48 && porcentaje2 < 55){
				r8.sprite = sprite2;}
			if(porcentaje2 >= 56 && porcentaje2 < 60){
				r8.sprite = sprite3;}
		}	
		if(porcentaje2 < 80) // 60% - 80%
		{	
			//3 condiciones
			if(porcentaje2 >= 61 && porcentaje2 < 67){
				r9.sprite = sprite1;}
			if(porcentaje2 >= 68 && porcentaje2 < 74){
				r9.sprite = sprite2;}
			if(porcentaje2 >= 75 && porcentaje2 < 80){
				r9.sprite = sprite3;}
		}	
		if(porcentaje2 <= 100) // 80% - 100%
		{	
			//3 condiciones
			if(porcentaje2 >= 81 && porcentaje2 < 86){
				r10.sprite = sprite1;}
			if(porcentaje2 >= 87 && porcentaje2 < 94){
				r10.sprite = sprite2;}
			if(porcentaje2 >= 100){
				r10.sprite = sprite3;}
		}

		//aca se	 coloca la barra	
	}

	void OnGUI()
	{
		GUI.skin = GUIMenuPrincipal;
		
		float inMarginW = W*0.26f;
		float inMarginH = H*0.33f;
		
		float internalW = W-(2*inMarginW);
		float internalH = H-(inMarginH*1.6f);

		GUI.Box(new Rect(32,10,34,200),"");
			
		GUI.Box(new Rect(W,10,34,200),"");

		if(estado.GameOver){
			GUI.Label(new Rect(0,0,Screen.width/2,(Screen.height)/2),"HA GANADO EL JUGADOR 1!");
			if(GUI.Button(new Rect(0,0,Screen.width/2,((Screen.height)*2)/3),"MAIN MENU"))
			{
				Application.LoadLevel("MainMenu");
			}
		}
	}
}

using UnityEngine;
using System.Collections;

public class ui_barscore : MonoBehaviour {

	private Gamestate estado;
	public GUISkin GUIMenuPrincipal;
	public Sprite sprite1;
	public Sprite sprite2;
	public Sprite sprite3;

	float W;
	float H;
	// Use this for initialization
	void Start()
	{
		W=Screen.width;
		H=Screen.height;
		estado = GameObject.Find("GameSetup").GetComponent<Gamestate>();
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
			if(porcentaje1 >= 0 && porcentaje1 < 7)	{SpriteRenderer r1 =	GameObject.Find("first1").GetComponent<SpriteRenderer>();
				r1.sprite = sprite1;
			}
			if(porcentaje1 >= 7 && porcentaje1 < 13){SpriteRenderer r1 =	GameObject.Find("first1").GetComponent<SpriteRenderer>();
				r1.sprite = sprite2;
			}
			if(porcentaje1 >= 14 && porcentaje1 < 20){SpriteRenderer r1 =	GameObject.Find("first1").GetComponent<SpriteRenderer>();
				r1.sprite = sprite3;
			}
		}	
		if(porcentaje1 < 40) // 20% - 40%
		{	
			//3 condiciones
			if(porcentaje1 >= 21 && porcentaje1 < 28){SpriteRenderer r1 =	GameObject.Find("first2").GetComponent<SpriteRenderer>();
				r1.sprite = sprite1;}
			if(porcentaje1 >= 29 && porcentaje1 < 35){SpriteRenderer r1 =	GameObject.Find("first2").GetComponent<SpriteRenderer>();
				r1.sprite = sprite2;}
			if(porcentaje1 >= 36 && porcentaje1 < 40){SpriteRenderer r1 =	GameObject.Find("first2").GetComponent<SpriteRenderer>();
				r1.sprite = sprite3;}
		}	
		if(porcentaje1 < 60) // 40% - 60%
		{	
			//3 condiciones
			if(porcentaje1 >= 41 && porcentaje1 < 47){SpriteRenderer r1 =	GameObject.Find("first3").GetComponent<SpriteRenderer>();
				r1.sprite = sprite1;}
			if(porcentaje1 >= 48 && porcentaje1 < 55){SpriteRenderer r1 =	GameObject.Find("first3").GetComponent<SpriteRenderer>();
				r1.sprite = sprite2;}
			if(porcentaje1 >= 56 && porcentaje1 < 60){SpriteRenderer r1 =	GameObject.Find("first3").GetComponent<SpriteRenderer>();
				r1.sprite = sprite3;}
		}	
		if(porcentaje1 < 80) // 60% - 80%
		{	
			//3 condiciones
			if(porcentaje1 >= 61 && porcentaje1 < 67){SpriteRenderer r1 =	GameObject.Find("first4").GetComponent<SpriteRenderer>();
				r1.sprite = sprite1;}
			if(porcentaje1 >= 68 && porcentaje1 < 74){SpriteRenderer r1 =	GameObject.Find("first4").GetComponent<SpriteRenderer>();
				r1.sprite = sprite2;}
			if(porcentaje1 >= 75 && porcentaje1 < 80){SpriteRenderer r1 =	GameObject.Find("first4").GetComponent<SpriteRenderer>();
				r1.sprite = sprite3;}
		}	
		if(porcentaje1 <= 100) // 80% - 100%
		{	
			//3 condiciones
			if(porcentaje1 >= 81 && porcentaje1 < 86){SpriteRenderer r1 =	GameObject.Find("first5").GetComponent<SpriteRenderer>();
				r1.sprite = sprite1;}
			if(porcentaje1 >= 87 && porcentaje1 < 94){SpriteRenderer r1 =	GameObject.Find("first5").GetComponent<SpriteRenderer>();
				r1.sprite = sprite2;}
			if(porcentaje1 >= 100){SpriteRenderer r1 =	GameObject.Find("first5").GetComponent<SpriteRenderer>();
				r1.sprite = sprite3;}
		}	

		//player 2
		if(porcentaje2 < 20) // 0% - 20%
		{
			if(porcentaje2 >= 0 && porcentaje2 < 7){SpriteRenderer r1 =	GameObject.Find("first6").GetComponent<SpriteRenderer>();
				r1.sprite = sprite1;
			}
			if(porcentaje2 >= 7 && porcentaje2 < 13){SpriteRenderer r1 = GameObject.Find("first6").GetComponent<SpriteRenderer>();
				r1.sprite = sprite2;
			}

			if(porcentaje2 >= 14 && porcentaje2 < 20){SpriteRenderer r1 = GameObject.Find("first6").GetComponent<SpriteRenderer>();

				r1.sprite = sprite3;
			}
		}	
		if(porcentaje2 < 40) // 20% - 40%
		{	
			//3 condiciones
			if(porcentaje2 >= 21 && porcentaje2 < 28){SpriteRenderer r1 =	GameObject.Find("first7").GetComponent<SpriteRenderer>();
				r1.sprite = sprite1;}
			if(porcentaje2 >= 29 && porcentaje2 < 35){SpriteRenderer r1 =	GameObject.Find("first7").GetComponent<SpriteRenderer>();
				r1.sprite = sprite2;}
			if(porcentaje2 >= 36 && porcentaje2 < 40){SpriteRenderer r1 =	GameObject.Find("first7").GetComponent<SpriteRenderer>();
				r1.sprite = sprite3;}
		}	
		if(porcentaje2 < 60) // 40% - 60%
		{	
			//3 condiciones
			if(porcentaje2 >= 41 && porcentaje2 < 47){SpriteRenderer r1 =	GameObject.Find("first8").GetComponent<SpriteRenderer>();
				r1.sprite = sprite1;}
			if(porcentaje2 >= 48 && porcentaje2 < 55){SpriteRenderer r1 =	GameObject.Find("first8").GetComponent<SpriteRenderer>();
				r1.sprite = sprite2;}
			if(porcentaje2 >= 56 && porcentaje2 < 60){SpriteRenderer r1 =	GameObject.Find("first8").GetComponent<SpriteRenderer>();
				r1.sprite = sprite3;}
		}	
		if(porcentaje2 < 80) // 60% - 80%
		{	
			//3 condiciones
			if(porcentaje2 >= 61 && porcentaje2 < 67){SpriteRenderer r1 =	GameObject.Find("first9").GetComponent<SpriteRenderer>();
				r1.sprite = sprite1;}
			if(porcentaje2 >= 68 && porcentaje2 < 74){SpriteRenderer r1 =	GameObject.Find("first9").GetComponent<SpriteRenderer>();
				r1.sprite = sprite2;}
			if(porcentaje2 >= 75 && porcentaje2 < 80){SpriteRenderer r1 =	GameObject.Find("first9").GetComponent<SpriteRenderer>();
				r1.sprite = sprite3;}
		}	
		if(porcentaje2 <= 100) // 80% - 100%
		{	
			//3 condiciones
			if(porcentaje2 >= 81 && porcentaje2 < 86){SpriteRenderer r1 =	GameObject.Find("first10").GetComponent<SpriteRenderer>();
				r1.sprite = sprite1;}
			if(porcentaje2 >= 87 && porcentaje2 < 94){SpriteRenderer r1 =	GameObject.Find("first10").GetComponent<SpriteRenderer>();
				r1.sprite = sprite2;}
			if(porcentaje2 >= 100){SpriteRenderer r1 =	GameObject.Find("first10").GetComponent<SpriteRenderer>();
				r1.sprite = sprite3;}
		}

		//aca se	 coloca la barra	
	}

	void onGUI()
	{
		GUI.skin = GUIMenuPrincipal;
		
		float inMarginW = W*0.26f;
		float inMarginH = H*0.33f;
		
		float internalW = W-(2*inMarginW);
		float internalH = H-(inMarginH*1.6f);

		GUI.Box(new Rect(2,2,200,50),"");
			
		GUI.Box(new Rect(internalW-2,internalH-2,200,50),"");
	}
}

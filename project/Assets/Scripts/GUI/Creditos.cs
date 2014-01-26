using UnityEngine;
using System.Collections;

public class Creditos : MonoBehaviour {

	public GUISkin GUIMenuPrincipal;
	public Texture2D gameImag;
	public GUIStyle styleTexto, styleMenu;
	
	float W;
	float H;
	// Use this for initialization
	void Start () {
		W=Screen.width;
		H=Screen.height;
	}

	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI (){
		
		
		GUI.skin = GUIMenuPrincipal;
		styleMenu.normal.background = gameImag;
		styleTexto.fontSize = 40;
		GUI.Box (new Rect(0, 0, W, H),"", styleMenu);
		
		float inMarginW = W*0.20f;
		float inMarginH = H*0.12f;
		float internalW = W-(2*inMarginW);
		float internalH = H-(inMarginH*1.6f);
		

		if(GUI.Button (new Rect(W- inMarginW , H - inMarginH, 200,200),"Menu", styleTexto))
		{
			AutoFade.LoadLevel("MainMenu",0.7f,0.7f,new Color(0.0f,0.0f,0.0f));
		}
	}
}

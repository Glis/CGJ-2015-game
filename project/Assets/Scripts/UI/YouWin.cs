using UnityEngine;
using System.Collections;

public class YouWin : MonoBehaviour {

	public GUISkin GUIMenuPrincipal;
	public Texture2D gameImag;
	public GUIStyle styleMenu, styleTexto;

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


		float inMarginW = W*0.04f;
		float inMarginH = H*0.3f;
		float internalW = W-(2*inMarginW);
		float internalH = H-(inMarginH*1.6f);

		GUILayout.BeginArea(new Rect(inMarginW,inMarginH+100, W-(2*inMarginW), inMarginH*3));


			if(GUI.Button(new Rect(0,internalH/2-100,185,70),"Play Again", styleTexto))
			{
				AutoFade.LoadLevel("GameScene",0.7f,0.7f,new Color(0.0f,0.0f,0.0f));
			}
			if(GUI.Button (new Rect(0,internalH/2-45,185,70),"Menu", styleTexto))
			{
				AutoFade.LoadLevel("MainMenu",0.7f,0.7f,new Color(0.0f,0.0f,0.0f));
			}
		GUILayout.EndArea();
	}
}

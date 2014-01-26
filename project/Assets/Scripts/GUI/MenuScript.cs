using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

	public GUISkin GUIMenuPrincipal;
	public Texture2D gameImag;

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

	void OnGUI()
	{
		GUI.skin = GUIMenuPrincipal;

		float inMarginW = W*0.26f;
		float inMarginH = H*0.33f;

		float internalW = W-(2*inMarginW);
		float internalH = H-(inMarginH*1.6f);

		GUI.Box (new Rect(0,0,W,H),"");
		GUILayout.BeginArea(new Rect(inMarginW,inMarginH, W-(2*inMarginW), H-(inMarginH*1.6f)));
			//GUI.Label(new Rect(internalW/2+62,internalH/2-10,150,70),"Desarrollado Por PaperSloth!");
			if(GUI.Button(new Rect(internalW/2-60,internalH/2-125,185,70),"PLAY"))
			{
				AutoFade.LoadLevel("GameScene",1,1,new Color(1.0f,1.0f,1.0f));
//			 	Application.LoadLevel("GameScene");
			}
			if(GUI.Button (new Rect(internalW/2-60,internalH/2-45,185,70),"CREDITS"))
			{
				//Application.LoadLevel("Credits")
			}
			if(GUI.Button(new Rect(internalW/2-60,internalH/2+35,185,70),"EXIT"))
			{
				Application.Quit();
			}
//			GUI.Button(new Rect(internalW/2+80,internalH/2+60,110,110), gameImage);
		GUILayout.EndArea();
	}

}

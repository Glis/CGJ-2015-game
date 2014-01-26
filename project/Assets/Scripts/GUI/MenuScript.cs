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

		GUI.Box (new Rect(0,0,Screen.width,Screen.height),"");
		GUILayout.BeginArea(new Rect(Screen.width*0.4f, Screen.height*0.18f, 600, Screen.height*0.5f));
			//GUI.Label(new Rect(internalW/2+62,internalH/2-10,150,70),"Desarrollado Por PaperSloth!");
			if(GUI.Button(new Rect(105,0,120,60),"PLAY"))
			{
				AutoFade.LoadLevel("GameScene",1,1,new  Color(0.0f,0.0f,0.0f));
//			 	Application.LoadLevel("GameScene");
			}
			if(GUI.Button (new Rect(0,50,300,60),"CREDITS"))
			{
				AutoFade.LoadLevel("Creditos",0.7f,0.7f,new  Color(0.0f,0.0f,0.0f));
			}
			if(GUI.Button(new Rect(100,100,120,60),"EXIT"))
			{
				Application.Quit();
			}
//			GUI.Button(new Rect(internalW/2+80,internalH/2+60,110,110), gameImage);
		GUILayout.EndArea();
	}

}

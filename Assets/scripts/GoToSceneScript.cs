using UnityEngine;
using System.Collections;

public class GoToSceneScript : MonoBehaviour 
{

	public string sceneName;

	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Space))
		{
			Application.LoadLevel(sceneName);
		}
	}
}

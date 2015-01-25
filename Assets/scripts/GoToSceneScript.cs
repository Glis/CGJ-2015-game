using UnityEngine;
using System.Collections;

public class GoToSceneScript : MonoBehaviour 
{

	public string sceneName;
	public bool exitAfterTime;
	public float exitTime;
	
	IEnumerator Start()
	{
		if(exitAfterTime)
			yield return new WaitForSeconds(exitTime);
		yield return null;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Space))
		{
			Application.LoadLevel(sceneName);
		}
	}
}

using UnityEngine;
using System.Collections;

public class ui_barscore : MonoBehaviour {

	public GameObject guiCopy;
	// Use this for initialization
	void Awake()
	{
		Vector3 behindPos = transform.position;
		behindPos = new Vector3(guiCopy.transform.position.x,guiCopy.transform.position.y -0.005f,guiCopy.transform.position.z-1);
		transform.position = behindPos;
	}
	
	// Update is called once per frame
	void Update () 
	{
		//aca se coloca la barra	
	}
}

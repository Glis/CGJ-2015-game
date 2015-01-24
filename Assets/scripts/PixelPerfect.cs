using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class PixelPerfect : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		Camera cameraComponent = GetComponent<Camera>();
		camera.orthographicSize = Screen.height / 2f * 1f / 100f;
	}
}

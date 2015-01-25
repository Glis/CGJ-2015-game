using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class BackgroundParallaxer : MonoBehaviour {

	public const float SPEED_MODIFIER = 0.01f;
	public float scrollSpeed;
	private Vector2 savedOffset;

	// Use this for initialization
	void Start () {
		float vertExtent = Camera.main.camera.orthographicSize;    
		
		transform.localScale = new Vector3(2.56f * vertExtent / 1.01f , vertExtent) * 2;
		savedOffset = renderer.sharedMaterial.GetTextureOffset("_MainTex");
	}
	
	// Update is called once per frame
	void Update () {


		float x = Mathf.Repeat((Camera.main.transform.position.x%100f) * scrollSpeed * SPEED_MODIFIER, 1);
		Vector2 offset = new Vector2(x,savedOffset.y);
		renderer.sharedMaterial.SetTextureOffset("_MainTex", offset);
	}
	
	void OnDisable()
	{
		renderer.sharedMaterial.SetTextureOffset("_MainTex", savedOffset);
	}	
}

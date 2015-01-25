using UnityEngine;
using System.Collections;

public class BackgroundParallaxer : MonoBehaviour {

	public const float SPEED_MODIFIER = 0.01f;
	public float scrollSpeed;
	private Vector2 savedOffset;

	// Use this for initialization
	void Start () {
		transform.localScale = transform.localScale * 1.2f;
		savedOffset = renderer.sharedMaterial.GetTextureOffset("_MainTex");
	}
	
	// Update is called once per frame
	void Update () 
	{
		float x = Mathf.Repeat((Camera.main.transform.position.x%100f) * scrollSpeed * SPEED_MODIFIER, 1);
		Vector2 offset = new Vector2(x,savedOffset.y);
		renderer.sharedMaterial.SetTextureOffset("_MainTex", offset);
	}
	
	void OnDisable()
	{
		renderer.sharedMaterial.SetTextureOffset("_MainTex", savedOffset);
	}	
}

using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class BackgroundParallaxer : MonoBehaviour {

	public const float SPEED_MODIFIER = 0.01f;
	public const float VERTICAL_OFFSET_MODIFIER = 0.07f;
	public float scrollSpeed;
	
	private float originalY;
	private Vector2 savedOffset;
	private float[] cameraVerticalBounds;

	// Use this for initialization
	void Start () {
		originalY = transform.position.y;
		
		cameraFollow followScript = Camera.main.GetComponent<cameraFollow>();
		if(followScript != null)
		{
			cameraVerticalBounds = new float[2];
			cameraVerticalBounds[0] = followScript.boundaries.position.y - followScript.boundaries.height * 0.5f + followScript.vertExtent;
			cameraVerticalBounds[1] = followScript.boundaries.position.y + followScript.boundaries.height * 0.5f - followScript.vertExtent;
		}
		float vertExtent = Camera.main.camera.orthographicSize;  
		transform.localScale = new Vector3(2.56f * vertExtent / 1.01f * 1.1f, vertExtent) * 2 * 1.3f;
		savedOffset = renderer.sharedMaterial.GetTextureOffset("_MainTex");
	}
	
	// Update is called once per frame
	void Update () 
	{
		float x = Mathf.Repeat((Camera.main.transform.position.x%100f) * scrollSpeed * SPEED_MODIFIER, 1);
		Vector2 offset = new Vector2(Mathf.Max(0f,x),Mathf.Max(0f,savedOffset.y));
		renderer.sharedMaterial.SetTextureOffset("_MainTex", offset);

		if(cameraVerticalBounds != null && cameraVerticalBounds.Length == 2)
		{
			float y = 1f-Mathf.InverseLerp(cameraVerticalBounds[0], cameraVerticalBounds[1], Camera.main.transform.position.y);
			transform.localPosition = new Vector3(0, y * scrollSpeed * VERTICAL_OFFSET_MODIFIER);
		}
	}
	
	void OnDisable()
	{
		renderer.sharedMaterial.SetTextureOffset("_MainTex", savedOffset);
	}	
}

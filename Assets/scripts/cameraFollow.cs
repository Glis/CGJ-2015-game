using UnityEngine;
using System.Collections;

public class cameraFollow : MonoBehaviour {


	public Transform target;
	public Transform leftwall,rightwall,roof,floor;

	float mapX;
	float mapY;

	private float minX;
	private float maxX;
	private float minY;
	private float maxY;

	// Use this for initialization
	void Start () {
		mapX = Mathf.Abs(rightwall.position.x - leftwall.position.x);
		//mapY = Mathf.Abs (roof.position.x - floor.position.y);
		//Esta restabdo la posicion en x??? no deberia sumarse?

		mapY = Mathf.Abs (roof.position.y + floor.position.y);

		float vertExtent = Camera.main.camera.orthographicSize;    
		float horzExtent = vertExtent * Screen.width / Screen.height;
		
		// Calculations assume map is position at the origin
		minX = horzExtent - mapX / 2.0f;
		maxX = mapX / 2.0f - horzExtent;
		minY = vertExtent - mapY / 2.0f;
		maxY = mapY / 2.0f - vertExtent;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (target.position.x, target.position.z, transform.position.z);
	}

	// Update is called once per frame
	void LateUpdate () {
		Vector3 v3 = transform.position;
		v3.x = Mathf.Clamp(v3.x, minX, maxX);
		v3.y = Mathf.Clamp(v3.y, minY, maxY);
		transform.position = v3;
	}
}

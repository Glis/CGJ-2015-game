using UnityEngine;
using System.Collections;

public class cameraFollow : MonoBehaviour {


	public Transform target;
	public Transform leftwall,rightwall,roof,floor;

	float mapX;
	float mapY;

	float mapWidth;
	float mapHeight;

	public float vertExtent;
	public float  horzExtent;

	public float minX;
	public float maxX;
	public float minY;
	public float maxY;

	public Rect boundaries;

	// Use this for initialization
	void Start () {
//		mapX = Mathf.Abs(rightwall.position.x - leftwall.position.x);
//		mapY = Mathf.Abs (roof.position.y - floor.position.y);

		mapWidth = boundaries.width;
		mapHeight = boundaries.height;

		//El mapa no se deberia mover!!
		mapX = boundaries.x;
		mapY = boundaries.y;

		vertExtent = Camera.main.camera.orthographicSize;    
		horzExtent = vertExtent * Screen.width / Screen.height;

		minX = (boundaries.x - mapWidth / 2) + horzExtent;
		maxX = (boundaries.x + mapWidth / 2) - horzExtent;

		minY = (boundaries.y - mapHeight / 2) + vertExtent;
		maxY = (boundaries.y + mapHeight / 2) - vertExtent;

		
		// Calculations assume map is position at the origin
//		minX = horzExtent;
//		minX = horzExtent - mapX / 2.0f;
//		maxX = mapX / 2.0f - horzExtent;
//
//		minY = vertExtent - mapY / 2.0f;
//		maxY = mapY / 2.0f - vertExtent;


	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (target.position.x, target.position.y, transform.position.z);
	}

	// Update is called once per frame
	void LateUpdate () {
		Vector3 v3 = transform.position;
		v3.x = Mathf.Clamp(v3.x, minX, maxX);
		v3.y = Mathf.Clamp(v3.y, minY, maxY);
		transform.position = v3;
	}

	void OnDrawGizmos() {
		Gizmos.DrawLine (boundaries.position + new Vector2( -boundaries.width / 2, boundaries.height / 2), 
		                 boundaries.position + new Vector2( boundaries.width / 2, boundaries.height / 2));

		Gizmos.DrawLine (boundaries.position + new Vector2( boundaries.width / 2, boundaries.height / 2), 
		                 boundaries.position + new Vector2( boundaries.width / 2, -boundaries.height / 2));

		Gizmos.DrawLine (boundaries.position + new Vector2( boundaries.width / 2, -boundaries.height / 2), 
		                 boundaries.position + new Vector2( -boundaries.width / 2, -boundaries.height / 2));

		Gizmos.DrawLine (boundaries.position + new Vector2 (-boundaries.width / 2, -boundaries.height / 2), 
		                 boundaries.position + new Vector2 (-boundaries.width / 2, boundaries.height / 2));
	}
}

#pragma strict

var mainCamera: Camera;

var top: BoxCollider2D;
var bottom: BoxCollider2D;
var left: BoxCollider2D;
var right: BoxCollider2D;

function Update () {
	top.size = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(Screen.width*2f, 0f, 0f)).x, 1f);
	top.center = new Vector2(0f, mainCamera.ScreenToWorldPoint(new Vector3(0f, Screen.height, 0f)).y + 0.5f);
	
	bottom.size = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(Screen.width*2f, 0f, 0f)).x, 1f);
	bottom.center = new Vector2(0f, mainCamera.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).y - 0.5f);
	
	left.size = new Vector2(1f, mainCamera.ScreenToWorldPoint(new Vector3(0f, Screen.height*2f, 0f)).y);
	left.center = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x - 0.5f, 0f);
	
	right.size = new Vector2(1f, mainCamera.ScreenToWorldPoint(new Vector3(0f, Screen.height*2f, 0f)).y);
	right.center = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x + 0.5f, 0f);
}
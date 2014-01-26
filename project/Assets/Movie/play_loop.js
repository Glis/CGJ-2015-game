#pragma strict

function Start () {
	var mov: MovieTexture = renderer.material.mainTexture;
	mov.loop = true;
	mov.Play();
}

function Update () {

}


function Start () {
	var mov: MovieTexture = renderer.material.mainTexture;
	mov.Play();
	yield(WaitForSeconds(mov.duration));
           Application.LoadLevel("Intro_Loop");
}

function Update () {

}
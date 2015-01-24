

function Start () {
		var mov: MovieTexture = renderer.material.mainTexture;
	mov.Play();
	yield(WaitForSeconds(mov.duration));
           Application.LoadLevel("Intro_Juego");
}

function Update () {

}
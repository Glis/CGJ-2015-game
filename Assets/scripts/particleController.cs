using UnityEngine;
using System.Collections;

public class particleController : MonoBehaviour {

	public AudioSource audio1;

	// Use this for initialization
	void Start () {
		// You can use particleSystem instead of
		// gameObject.particleSystem.
		// They are the same, if I may say so
		particleSystem.emissionRate = 0;
		particleSystem.renderer.sortingLayerName = "player";
	}

	// Update is called once per frame
	void Update () {
		if( Input.GetKeyDown("space") ) {
			particleSystem.Emit(50);
			//if(audio1.isReadyToPlay){
			audio1.Play();
			//}
		}
	}
}

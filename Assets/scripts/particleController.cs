using UnityEngine;
using System.Collections;

public class particleController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// You can use particleSystem instead of
		// gameObject.particleSystem.
		// They are the same, if I may say so
		particleSystem.emissionRate = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if( Input.GetKeyDown("space") ) {
			particleSystem.Emit(20);    
		}
	}
}

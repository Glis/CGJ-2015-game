using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class InitBase : MonoBehaviour {
	public Sprite background_file;
	public GameObject[] childs;

	// Use this for initialization
	void Start () {
		GameObject container;
		GameObject backgroundPanel;
		SpriteRenderer renderer;

		foreach(GameObject child in childs) {
			renderer = child.GetComponent<SpriteRenderer>();

			if(!renderer) {
				renderer = child.AddComponent<SpriteRenderer>();
			}
			renderer.sprite = background_file;

		}
		

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

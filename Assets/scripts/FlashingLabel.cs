using UnityEngine;
using System.Collections;

public class FlashingLabel : MonoBehaviour {

	public GameObject flashing_Label;
	
	public float interval;
	// Use this for initialization
	void Start () {
		InvokeRepeating("FlashLabel", 0, interval);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FlashLabel()
	{
		if(flashing_Label.activeSelf)
			flashing_Label.SetActive(false);
		else
			flashing_Label.SetActive(true);
	}
}

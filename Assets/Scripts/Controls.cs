using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour {

	public ArrayList _texts;
	
	public GameObject _firstText;
	public float _duration;
	
	// Use this for initialization
	void Start () {
		iTween.FadeTo(_firstText, 0, 0);
		_firstText.renderer.enabled = false;
		//iTween.ScaleFrom(_firstText, new Vector3(0.25f,0.25f,0.4f), 0.5f);
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonUp("Jump")) {
			_firstText.renderer.enabled = true;
			iTween.FadeTo(_firstText, iTween.Hash("alpha",1,"time", 1));
		}
	}
	
	void FirstTextFinished() {
		Debug.Log ("First text finished");
		
	}
	
	
}

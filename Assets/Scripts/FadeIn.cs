using UnityEngine;
using System.Collections;

public class FadeIn : MonoBehaviour {
	
	public float _duration = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void Fade () {
		iTween.FadeTo(gameObject,0,_duration);
	}
}

using UnityEngine;
using System.Collections;

public class MenuButton : MonoBehaviour {
	
	public string _pathName;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnMouseEnter() {
		renderer.material.color = Color.magenta;
	}
	void OnMouseExit() {
		renderer.material.color = Color.white;
	}
	
	void OnMouseUp() {
		Debug.Log ("click");
		if (_pathName != "") {
			iTween.MoveTo(Camera.main.gameObject, iTween.Hash("path", iTweenPath.GetPath(_pathName), "time", 0.5));
		}
	}
	
}

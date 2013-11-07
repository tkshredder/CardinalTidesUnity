using UnityEngine;
using System.Collections;

public class UpdateDesc : MonoBehaviour {
	
	public CommandPanel _commandPanel;
	public SelectCrewMember _scm;
		
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (UICamera.hoveredObject == gameObject) {
			//Debug.Log ("Ya got me!");
			_commandPanel.setDescription(_scm.GetCurrentCommandDesc());
		}
	}
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CommandPanel : MonoBehaviour {
	
	public List<GameObject> _commandButtons;
	public UILabel _descriptionLabel;
	public UILabel _outcomeLabel;
	
	// lol the wrong way...
	public List<UILabel> _commandLabels;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void setDescription (string desc) {
		
		_descriptionLabel.text = desc; 
	}
}

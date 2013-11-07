using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CrewMember : MonoBehaviour {
	
	public string _name;
	public int _attack;
	public int _defense;
	public int _skill;
	public int _dodge;
	public bool _isCaptain = false;
	
	// TO DO:
	// Put these into proper objects
	public string _command1 = "Command 1";
	public string _command2 = "Command 2";
	public string _command1desc = "desc 1";
	public string _command2desc = "desc 2";
	
	public List<Command> _availableCommands;
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

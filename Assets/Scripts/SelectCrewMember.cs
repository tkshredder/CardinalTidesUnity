using UnityEngine;
using System.Collections;
using System.Collections.Generic;
//using Holoville.HOTween;
//using Holoville.HOTween.Plugins;
	
public class SelectCrewMember : MonoBehaviour {
	
	private int _currentCrewIndex;
	
	public GameObject _shipCamera;
	public List<GameObject> crewMembers;
	public CommandPanel _commandPanel;
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonUp("Horizontal") && Input.GetAxis("Horizontal") < 0) {
			
			_currentCrewIndex--;
			if (_currentCrewIndex < 0) {
				_currentCrewIndex = crewMembers.Count-1;
			}
		}
		if (Input.GetButtonUp("Horizontal") && Input.GetAxis("Horizontal") > 0) {
			_currentCrewIndex++;
			if (_currentCrewIndex >= crewMembers.Count) {
				_currentCrewIndex = 0;
			}
		}
		
		// Move the camera to the x position of the current cube:
		//Camera.main.transform.position.x = crewMembers[_currentCrewIndex].transform.position.x;
		//HOTween.To(_shipCamera.transform, 0.2f, "position", new Vector3(crewMembers[_currentCrewIndex].transform.position.x,_shipCamera.transform.position.y,_shipCamera.transform.position.z));
		
		iTween.MoveTo(_shipCamera, new Vector3(crewMembers[_currentCrewIndex].transform.position.x,_shipCamera.transform.position.y,_shipCamera.transform.position.z), 0.2f);
		
		_commandPanel.setDescription(_currentCrewIndex.ToString());
		
	}
}

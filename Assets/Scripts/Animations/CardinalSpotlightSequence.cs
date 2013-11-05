using UnityEngine;
using System.Collections;

public class CardinalSpotlightSequence : MonoBehaviour {

	private Vector3 _startingCameraPosition; // used to save the starting camera position for resetting the sequence
	
	
	
	// Use this for initialization
	void Start () {
		// Set starting camera
		_startingCameraPosition = gameObject.transform.position;
		
		GameObject cardinal = GameObject.Find("Cardinal");
		
		// Zoom Cardinal up:
		iTween.MoveFrom(cardinal, iTween.Hash("x", cardinal.transform.position.x-10, "time", 2, "easetype",iTween.EaseType.easeOutSine));

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonUp("Jump")) {
			
			// Reset camera:
			gameObject.transform.position = _startingCameraPosition;
			
			// Animate mainCharacter:
			//_mainCharacterTexture.Play(0);
			
			GameObject spotlight = GameObject.Find("Spotlight");
			
			// Zoom Camera up:
			iTween.MoveTo(spotlight, iTween.Hash("path", iTweenPath.GetPath("SpotlightIn"),"time",4,"easetype",iTween.EaseType.easeInOutSine, "oncompletetarget", gameObject,"oncomplete","CameraZoomComplete"));		
		
		}
	}
	
	void CameraZoomComplete() {
		GameObject cardinal = GameObject.Find("Cardinal");
		
		// Zoom Cardinal up:
		iTween.MoveTo(cardinal, iTween.Hash("path", iTweenPath.GetPath("CardinalIn"),"time",4,"easetype",iTween.EaseType.easeInOutSine, "oncompletetarget", gameObject,"oncomplete","CameraZoomComplete"));
	}
}

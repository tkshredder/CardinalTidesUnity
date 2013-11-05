using UnityEngine;
using System.Collections;

public class ActionAnimation : MonoBehaviour {
	
	private Vector3 _startingCameraPosition;
	
	public int _shakeDuration = 1;
	public AnimateTiledTexture _mainCharacterTexture;
	public AudioSource _mainCharacterAudio; 
	public GameObject _burstLayer;
	
	
	// Use this for initialization
	void Start () {
		
		// Set starting camera
		_startingCameraPosition = gameObject.transform.position;
		
		// Set up callback function for the Main Character animation
		_mainCharacterTexture.RegisterCallback(AnimationFinished);
		
		// Hide the burst Layer
		_burstLayer.renderer.enabled = false;
	}
	
	void CameraZoomComplete() {
		
		// Set up Camera Shake tween:
		Hashtable ht = new Hashtable();
		ht.Add("x",0.5f);
		ht.Add("y",0.5f);
		ht.Add("time",_shakeDuration);
		
		// Shake it like a polaroid picture:
		iTween.ShakePosition(Camera.main.gameObject, ht);
		
		// Enable the Burst layer for rendering & Flash the burst:
		_burstLayer.renderer.enabled = true;
		iTween.FadeTo(_burstLayer, iTween.Hash("alpha",0,"onCompleteTarget",gameObject,"onComplete","BurstFinished"));
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetButtonUp("Jump")) {
			
			// Reset camera:
			gameObject.transform.position = _startingCameraPosition;
			
			// Animate mainCharacter:
			_mainCharacterTexture.Play(0);
			
			// Zoom Camera up:
			iTween.MoveTo(gameObject, iTween.Hash("z",gameObject.transform.localPosition.z-2,"time",1,"easetype",iTween.EaseType.easeInOutSine, "oncomplete","CameraZoomComplete"));		
		
		}
	}
	
	// This function will get called by the Main Character Texture when the animation is completed.
	// EnableEvents option must be set to true
	void AnimationFinished() {
		
		// play crunch sound
		AudioSource.PlayClipAtPoint(_mainCharacterAudio.clip, Camera.main.transform.position);
		
		print ("animation finished");
		
		// show burst
		_mainCharacterTexture.Reset();
		
	}
		
	void BurstFinished() {
		print ("burst finished");
		_burstLayer.renderer.enabled = false;
		iTween.FadeTo(_burstLayer, iTween.Hash("alpha",1,"time",1));
	}
}

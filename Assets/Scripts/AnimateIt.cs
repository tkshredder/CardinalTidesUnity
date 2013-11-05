using UnityEngine;
using System.Collections;

public class AnimateIt : MonoBehaviour {

	void Start()
	{
	    if (_animatedTileTexture == null)
	    {
	        Debug.LogWarning("No animated tile texture script assigned!");
	    }
	    else {
	        _animatedTileTexture.RegisterCallback(AnimationFinished);
			_animatedTileTexture.Play();
			
			Hashtable ht = new Hashtable();
			ht.Add("path",iTweenPath.GetPath("path1"));
			ht.Add("time",6);
			ht.Add("easetype",iTween.EaseType.easeInOutSine);
			//ht.Add("looptype",iTween.LoopType.pingPong);
			iTween.MoveTo(gameObject, ht);
		
		}
	}
	 
	// This function will get called by the AnimatedTiledTexture script when the animation is completed if the EnableEvents option is set to true
	void AnimationFinished()
	{
		print ("animation finished");
		
		Hashtable ht = new Hashtable();
		ht.Add("x",0.5f);
		ht.Add("y",0.5f);
		ht.Add("time",10.0f);
		 
		iTween.ShakePosition(Camera.main.gameObject, ht);
	        // The animation is finished
	}
	 
	public AnimateTiledTexture _animatedTileTexture;    // A reference to AnimatedTileTexture object
	
	
}

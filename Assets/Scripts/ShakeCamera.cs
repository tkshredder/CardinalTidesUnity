using UnityEngine;
using System.Collections;

public class ShakeCamera : MonoBehaviour {
	
	public int _duration = 1;
	
	// Use this for initialization
	void Start () {
		Hashtable ht = new Hashtable();
		ht.Add("x",0.5f);
		ht.Add("y",0.5f);
		ht.Add("time",_duration);
		 
		//iTween.ShakePosition(mainCamera, ht);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

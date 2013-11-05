﻿using UnityEngine;
using System.Collections;

public class FloatObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//iTween.MoveTo(gameObject, iTween.Hash("path",iTweenPath.GetPath("path1"),"time",10,"easetype",iTween.EaseType.easeInOutSine,"looptype",iTween.LoopType.pingPong));
		iTween.MoveTo(gameObject, iTween.Hash("y",gameObject.transform.localPosition.y+2,"time",5,"easetype",iTween.EaseType.easeInOutSine,"looptype",iTween.LoopType.pingPong));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
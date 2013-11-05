using UnityEngine;
using System.Collections;

public class ButtonListener : MonoBehaviour {
	
	public UILabel description;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (UICamera.hoveredObject != null) {
			// get current hoveredObject
			//Debug.Log (UICamera.hoveredObject);
			//Debug.Log (UICamera.hoveredObject.GetComponent("CommandDetails"));
			CommandDetails test = UICamera.hoveredObject.GetComponent("CommandDetails") as CommandDetails;
			description.text = test._message;
			
		}
	}
}

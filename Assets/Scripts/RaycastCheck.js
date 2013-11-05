#pragma strict

function Start () {

}

function Update () {
	var ray = Camera.main.ScreenPointToRay (Input.mousePosition);
    var hit : RaycastHit;
    if (Physics.Raycast (ray, hit, 1000)) {
    	Debug.Log("You hit: "+hit.collider.gameObject);
    	
    	
    	
    }
}
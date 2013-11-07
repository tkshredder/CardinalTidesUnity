using UnityEngine;
using System.Collections;

public class Command : AbstractCommand {

	public override void Execute() {
		Debug.Log ("execute command: " + commandName);
	}
}
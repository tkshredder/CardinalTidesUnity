using UnityEngine;
using System.Collections;

public abstract class AbstractCommand : ICommand {
  
	protected string commandName;
	protected string commandDescription;
	
	public abstract void Execute();

}
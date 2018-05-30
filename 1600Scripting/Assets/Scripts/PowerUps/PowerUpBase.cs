using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PowerUpBase : FunctionBase
{
	public FloatBase PowerLevel;
	
	public override void Run(object obj)
	{
		var newObj = obj as FloatBase;
		if (newObj != null) newObj.Value += PowerLevel.Value;
	}
}
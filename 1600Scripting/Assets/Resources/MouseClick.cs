using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{

	public FloatBase Data;

	private void OnMouseDown()
	{
		Data.Value += 0.1f;
	}
}

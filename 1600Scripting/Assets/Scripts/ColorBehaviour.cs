﻿using UnityEngine;
using UnityEngine.UI;

public class ColorBehaviour : MonoBehaviour
{
	public ChangeUIColor ChangeColor;
	
	void Start () {
		ChangeColor.ColorUI( GetComponent<Image>() );
	}
	
}

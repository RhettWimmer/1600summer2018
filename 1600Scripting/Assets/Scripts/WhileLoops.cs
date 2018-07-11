using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class WhileLoops : MonoBehaviour
{

	public Text DisplayText;

	public int i = 3;
	
	// Use this for initialization
	void Start ()
	{
		StartCoroutine(  Ticker()  );
	}

	IEnumerator Ticker()
	{
		while (i > 0)
		{
			DisplayText.text = i.ToString();
			
			yield return new WaitForSeconds(1);
			i--;
		}

		DisplayText.text = "Go!";

		yield return new WaitForSeconds(2);

		DisplayText.text = "";
		
		
		//call a function
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//Made By Anthony Romrell
public class AiSpawner : MonoBehaviour
{

	public GameObject Ai;
	public Transform Destination;
	public Level CurrentLevel;
	private int aiCount;
	
	private void Start()
	{
		aiCount = CurrentLevel.AiCount;
		StartCoroutine(StartSpawn());
	}

	private IEnumerator StartSpawn()
	{
		while (aiCount > 0)
		{
			GameObject newAI = Instantiate(Ai);
			newAI.GetComponent<AIMovement>().Destination = Destination;
			aiCount--;
			
			yield return new WaitForSeconds(CurrentLevel.Time);
		}
	}	
}
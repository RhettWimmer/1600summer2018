using UnityEngine;
using UnityEngine.AI;

//Made By Anthony Romrell

[RequireComponent( typeof( NavMeshAgent ) )]

public class AIMovement : MonoBehaviour
{
	private NavMeshAgent Agent;
	public Transform Destination;
	public AiControl Control;
	
	private void Start()
	{
		Agent = GetComponent<NavMeshAgent>();
		Control.ConfigAI(Agent);
	}

	private void Update()
	{
		Agent.destination = Destination.position;
	}
}
using UnityEngine;
using UnityEngine.AI;

//Made By Anthony Romrell

[CreateAssetMenu]
public class AiControl : ScriptableObject
{
	public float Speed;
	public float AngularSpeed;

	public void ConfigAI(NavMeshAgent agent)
	{
		agent.speed = Speed;
		agent.angularSpeed = AngularSpeed;
	}
}

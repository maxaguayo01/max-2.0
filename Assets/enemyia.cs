using UnityEngine;
using System.Collections;

public class enemyia : MonoBehaviour {

	protected NatMeshAgent agent;

	public float walkspeed = 2f;
	public float turnspeed = 180f;

	// Use this for initialization
	void Start () {
	
		agent = GetComponent <NavMeshAgent> ();

		if(agent)
		{
			Debug.LogError(name + "has no NavMeshAgent")
			enabled = false;
			return;

	
	    
	// Update is called once per frame
	void Update () {
	
	}
}

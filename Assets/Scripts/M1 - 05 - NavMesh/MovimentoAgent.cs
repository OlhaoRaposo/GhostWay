using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovimentoAgent : MonoBehaviour
{
	[SerializeField] private GameObject destino;
	private NavMeshAgent navMeshAgent;

	private void Start()
	{
		destino = GameObject.Find("Destino");
		navMeshAgent = GetComponent<NavMeshAgent>();
		navMeshAgent.destination = destino.transform.position;
	}

    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Bala"))
        {
			Destroy(this.gameObject);
        }
        if (col.gameObject.CompareTag("Portao"))
        {
            Destroy(this.gameObject);
        }
    }
}

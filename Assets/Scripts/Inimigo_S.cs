using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Inimigo_S : MonoBehaviour
{
    [SerializeField] private GameObject destino;
    private NavMeshAgent navMeshAgent;
    public int vidas = 3;   

    private void Start()
    {
        destino = GameObject.Find("Destino");
        navMeshAgent = GetComponent<NavMeshAgent>();
        navMeshAgent.destination = destino.transform.position;
    }

    public void FixedUpdate()
    {
        if (vidas <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Bala"))
        {
            vidas--;
        }
        if (col.gameObject.CompareTag("Portao"))
        {
            Destroy(gameObject);
        }
    }

}

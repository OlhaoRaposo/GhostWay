using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Inimigo_S : MonoBehaviour
{
    [SerializeField] private GameObject destino, hud;
    private NavMeshAgent navMeshAgent;
    public int lifes = 3;

    private void Start()
    {
        destino = GameObject.Find("Destino");
        navMeshAgent = GetComponent<NavMeshAgent>();
        navMeshAgent.destination = destino.transform.position;
        hud = GameObject.Find("HUD");
    }

    public void FixedUpdate()
    {
        if (lifes <= 0)
        {
            hud.gameObject.GetComponent<UI_S>().money += 20;
            hud.gameObject.GetComponent<UI_S>().AtualizaMoney();
            Destroy(gameObject);
        }
    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Bala"))
        {
            lifes--;
            hud.gameObject.GetComponent<UI_S>().money += 5;
            hud.gameObject.GetComponent<UI_S>().AtualizaMoney();
        }
        if (col.gameObject.CompareTag("Portao"))
        {
            Destroy(gameObject);
        }
    }
    public void Die()
    {
        Destroy(gameObject);
    }

}

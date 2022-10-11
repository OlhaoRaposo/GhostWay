using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetil : MonoBehaviour
{
    [SerializeField] private Transform target;

    [SerializeField] private float velocidade = 70f;


    public void BuscarAlvo(Transform umTarget)
    {
        target = umTarget;
    }

    // Implementa a logica de verificacao de alvo.
    // Se o alvo nao existir, destrua o projetil
    private void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        // Calcula a direcao para onde o tiro vai ser disparado 
        Vector3 direcao = target.position - transform.position;

        //Calcula a distancia a ser percorrida float distanciaNesteFrame = speed * Time.deltaTime;
        float distanciaNesteFrame = velocidade * Time.deltaTime;

        // Verifica se acertamos o target
       if (direcao.magnitude <= distanciaNesteFrame)
        {
            AcertarAlvo();
            return;
        }

        // Se nao tivermos acertado o target, vamos fazer a movimentacao do projetil
        transform.Translate(direcao.normalized * distanciaNesteFrame, Space.World);

    }

    private void AcertarAlvo()
    {
        Destroy(gameObject);
    }
}

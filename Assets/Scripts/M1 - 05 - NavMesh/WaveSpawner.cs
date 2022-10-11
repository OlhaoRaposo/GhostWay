using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private float timeBetweenWaves = 5f;
    [SerializeField] private int waveNumber = 1;
    [SerializeField] private float timeBetweenSpawns = 0.5f;
    [SerializeField] private float waveTime = 3f;

    [SerializeField] private Text Waves;
    

    public GameObject[] CheckObjects;
    private bool newWave = true;
    public UI_S UI;

    private void Start()
    {
        StartCoroutine(StartWave());
    }
    private void Update()
    {
        WaveIsOver();
        Waves.text = (waveNumber).ToString();
    }

    private IEnumerator SpawnWave()
    {
        newWave = false;
        for (int i = 0; i < waveNumber; i++)
        {
            SpawnEnemy();
            // Espera 0.5 segundos a cada chamada de SpawnEnemy
            yield return new WaitForSeconds(timeBetweenSpawns);

        }
        waveNumber++;
        //Debug.Log("Iniciando nova Wave!");

    }
   
    private IEnumerator StartWave()
    {
        yield return new WaitForSeconds(waveTime);
        if (newWave == true)
        {
            StartCoroutine(SpawnWave());
        }
        StartCoroutine(StartWave());
    }

    public void WaveIsOver()
    {
        CheckObjects = GameObject.FindGameObjectsWithTag("inimigo");

        if(CheckObjects.Length == 0)
        {
            newWave = true;
        }
    }
    private void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
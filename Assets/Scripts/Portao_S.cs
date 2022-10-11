using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Portao_S : MonoBehaviour
{
    public GameObject openGate;
    public GameObject closeGate;
    public int Gatelife;
    public Text life;
    public bool isClosed = true;
    public Collider coll;

    public void Start()
    {
        closeGate.SetActive(true);
        openGate.SetActive(false);
    }
    public void FixedUpdate()
    {
        if (Gatelife <= 0)
        {
            closeGate.SetActive(false);

            openGate.SetActive(true);
            coll.enabled = false;
        }    
    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("inimigo"))
        {
            Gatelife -= 2;
            if (Gatelife >= 0)
            {
                life.text = (Gatelife).ToString();
            }
            else
            {
                life.text = "0";
            }
        }
    }
}

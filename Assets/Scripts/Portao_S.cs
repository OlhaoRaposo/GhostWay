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

    public UI_S hud;

    public void Start()
    {
        closeGate.gameObject.SetActive(true);
        openGate.gameObject.SetActive(false);
    }
    public void FixedUpdate()
    {
        if (Gatelife <= 0)
        {
            closeGate.gameObject.SetActive(false);
            openGate.gameObject.SetActive(true);
            coll.enabled = false;
        }    
    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("inimigo"))
        {
            Gatelife -= 1;
            
            if (Gatelife >= 0)
            {
                hud.AtualizaLife();
            }
            else
            {
                life.text = Gatelife.ToString();
            }
        }
    }
}

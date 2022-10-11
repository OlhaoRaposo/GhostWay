using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loja_S : MonoBehaviour
{
    public int money;
    public int price;
    public GameObject obj;

    public void BuyItem()
    {
        if (money >= price)
        {
            money -= price;
            SpawItem();
        }
        else
        {
            Debug.Log("Sem dinheiro");
        }
    }
    private void SpawItem()
    {
        Instantiate(obj);
    }
}

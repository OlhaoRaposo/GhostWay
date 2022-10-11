using UnityEngine;
using UnityEngine.UI;

public class UI_S : MonoBehaviour
{
    public Text txtMoney;
    public Text txtWave;
    public int money = 300;

    public WaveSpawner spawn;

    public void Start()
    {
        txtMoney.text = (money).ToString();;
    }
    public void FixedUpdate()
    {
        
    }
    public void AtualizaMoney(){
        txtMoney.text = (money).ToString();;
    }

}

using UnityEngine;
using UnityEngine.UI;

public class UI_S : MonoBehaviour
{
    public Text txtMoney;
    public Text txtWave;
    public Text txtLife;
    public int money = 300;

    public WaveSpawner spawn;
    public Portao_S gate;

    public void Start()
    {
        txtMoney.text = (money).ToString();;
        txtLife.text = (gate.Gatelife).ToString();
    }
    public void FixedUpdate()
    {
        
    }
    public void AtualizaMoney(){
        txtMoney.text = (money).ToString();;
    }
    public void AtualizaLife()
    {
        txtLife.text = (gate.life).ToString();
    }

}

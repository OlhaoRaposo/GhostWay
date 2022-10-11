using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public void TrocarCena(string cena){
        SceneManager.LoadScene(cena);
    }
    public void FecharJogo(){
        Application.Quit();
    }
    public void AbrirTela(GameObject tela){
        tela.SetActive(true);
        Time.timeScale = 0;
    }
    public void FecharTela(GameObject tela){
        tela.SetActive(false);
        Time.timeScale = 1;
    }
}

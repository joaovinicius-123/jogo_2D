using UnityEngine;
using UnityEngine.SceneManagement;

public class reiniciar : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Reiniciar()  //Identifica-rá qual função o script irá executar.
    
    {
        SceneManager.LoadScene("jogo");  //Vai carregar uma cena específica,chamada de "jogo".
    }

}

   

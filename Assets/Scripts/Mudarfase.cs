using UnityEngine;
using UnityEngine.SceneManagement;

public class Mudarfase : MonoBehaviour //nome da função do script
{
    public void OnCollisionEnter2D(Collision2D collision) //um código que fará uma condição especifica ao encostar no colisor
    {
        if (collision.gameObject.CompareTag("Player"))// verifica se o objeto com o qual o jogador colidiu tem a tag "Portal"
        {
            Debug.Log("teste"); //um print para fazer o código funcionar.
            SceneManager.LoadScene("telavitoria");// faz com que o jogo reinicie quando o jogador colidir com um objeto com a tag "Portal"
        }
    }
    
}

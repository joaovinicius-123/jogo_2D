using UnityEngine;
using UnityEngine.SceneManagement;

public class Mudarfase : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))// verifica se o objeto com o qual o jogador colidiu tem a tag "Portal"
        {
            Debug.Log("teste");
            SceneManager.LoadScene("telavitoria");// faz com que o jogo reinicie quando o jogador colidir com um objeto com a tag "Portal"
        }
    }
    
}

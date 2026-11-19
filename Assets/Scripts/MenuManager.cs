using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour //Menu inicial
{
    public void StartGame() //button start game
    {
       SceneManager.LoadScene("jogo"); //ao ser clicado roda a cena "jogo"
    }

public void QuitGame() //button Quitgame
    {
        Application.Quit(); //ao ser clicado sai do jogo.
    }

}

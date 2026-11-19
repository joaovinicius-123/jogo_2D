using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuScene : MonoBehaviour //nome na qual fará parte do menu Scene
{
    public GameObject painelPause;  
    public GameObject painelGameOver; 

    bool pausado = false;  
    bool jogoAcabou = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        painelPause.SetActive(false); //vai mostrar a posição da ativação do painel em determinado tempo, se jogo está rodando o painel fica desativado
        painelGameOver.SetActive(false); // caso o jogo esteja rodando apinel desativado

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) //vai retornar o resultado ao clicar em um botão de pausado e não está
        {
            if (pausado) //se estiver pausado
            {
                Continuar(); //clicar na tecla continuar para retomar
            } else
            {
                Pausar(); //se não fica pausado
            }
        }
    }


    public void Pausar()  //script do jogo pausado
    {
        if (jogoAcabou == false) //se jogo acabou
        {
            pausado = true;  //pausado fica true
            painelPause.SetActive(true); //painel pause ativa
            Time.timeScale = 0f; //e volta ao menu
        }
    }

    public void Continuar() //script para continuar
    {
        pausado = false; //pausado desativa
        painelPause.SetActive(false); //painel desativa e volta a cena jogo
        Time.timeScale = 1f; //roda a cena jogo
    }

    public void MostrarGamerOver() //mostra quando o player encosta em um objeto de tag dano.
    {
        jogoAcabou = true; //jogo acaba
        painelGameOver.SetActive(true); //painel GAameover ativa
        Time.timeScale = 0f; //roda cena 0
    }

    public void Reiniciar() //Button reiniciar
    {
        Time.timeScale = 1f; //reinicia na cena do jogo
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //vai rodar por meio do script Scenemanager
    }
    public void VoltarMenu() //Button voltar menu
    {
        Time.timeScale = 1f; //para na cena jogo
        SceneManager.LoadScene(0); //retorna no menu

    }


}

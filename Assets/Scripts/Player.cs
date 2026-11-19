using UnityEngine;
using UnityEngine.SceneManagement; 

public class Player : MonoBehaviour
{
    public float speed = 20f;  
      


    private Rigidbody2D rb; 

    private bool isGrounded = false;

    public MenuScene menu; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() //inicio
    {
        rb = GetComponent<Rigidbody2D>();  //pega os valores do rigidbody 2D

    }

    // Update is called once per frame
    void Update() //executa somente uma vez.
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); //Vai reconhecer o movimento horizontal

        rb.linearVelocity = new Vector2(moveHorizontal * speed, rb.linearVelocity.y); //Fará o objeto se movimentar para a direção do eixo x e y;

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded) //Atribuirá o movimento de pulo na tecla espaço
        {
            rb.AddForce(new Vector2(0f, 10f), ForceMode2D.Impulse); //Vai desenvolver a fisica necessaria para o objeto pular
        }
    }

     void OnCollisionEnter2D (Collision2D collision) //uma mecanica para fazer reconhecer o chão como colisor e assim fazer o pulo.
    {
        if (collision.gameObject.CompareTag("Ground")) //uma tag de ground que ao encostar nela vai ser feita o reconhecimento do chão
        {
            isGrounded = true; //Vai reconhecer quando o jogador esta no chão.
        }

        if (collision.gameObject.CompareTag("dano")) //uma tag de dano que ao tocar em um objeto com essa tag, fará uma questão específica
        {
            menu.MostrarGamerOver(); //vai mostrar o game over  quando encostar em um objeto da tag dano e após ir para o menu.
        }
    }

    void OnCollisionExit2D( Collision2D collision)

    {   
        if (collision.gameObject.CompareTag("Ground")) //uma condição que diz que se encostar em um objeto com a tag ground fará algo específico.
        {
            isGrounded = false; //vai reconhecer quando o jogador não estiver no chão
        }
      
    }
}

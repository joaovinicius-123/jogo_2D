using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform alvo;
    public Vector3 distancia = new Vector3(0f, 0f, -10f);  
    public bool movimentoSuave = true; 
    public float velocidade = 5f;


    void LateUpdate()   //executa primeiro o update e após o lateupdate
    {
        Vector3 posicaoDesejada = alvo.position + distancia; //a posição desejada receberá o valor da distancia e do alvo, podendo personalizar


        if (movimentoSuave) //se o movimento suave for positivo
        {
            transform.position = Vector3.Lerp(transform.position, posicaoDesejada, velocidade * Time.deltaTime); //será executado a transformação da posição, posição desejada a velocidade multiplicado pelo timedelta e assim fará a movimentação
        }
        else //senão
        {
            transform.position = posicaoDesejada;   //retornará a posição desejada
        }



    }





}

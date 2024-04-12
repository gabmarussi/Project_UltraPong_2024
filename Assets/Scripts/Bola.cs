using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Bola : MonoBehaviour
{
    public float velocidade = 10;

    public TMP_Text pontuacaoEsquerda;
    public TMP_Text pontuacaoDireita;

    int pontosEsquerda = 0;
    int pontosDireita = 0;
 
    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(0,2) == 0 ? -1:1;
       
        float y = Random.Range(0,2) == 0 ? -1:1;
        GetComponent<Rigidbody>().velocity = new Vector2(velocidade*x,velocidade*y);
        
        pontuacaoEsquerda.SetText(pontosEsquerda.ToString());
        pontuacaoDireita.SetText(pontosDireita.ToString());
    }

    // Update is called once per frame
    void Update()
    {
      
    }


    void OnCollisionEnter(Collision batida)
    {
        if (batida.gameObject.name == "BEsquerda")
        {
            transform.position = new Vector3(0, 1, 9);
            pontosDireita++;
            Start();
        }
        else if (batida.gameObject.name == "BDireita")
        {
            transform.position = new Vector3(0, 1, 9);
            pontosEsquerda++;
            Start();
        }
    }
}

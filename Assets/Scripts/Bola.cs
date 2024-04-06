using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
public class Bola : MonoBehaviour
{
    public float velocidade = 10;
    // Start is called before the first frame update
    void Start()
    {
        
        float x = Random.Range(0,2) == 0 ? -1:1;
        /*float x1 = Random.Range(0,2);
        if(x1==0){
            x1=-1;
        }else
        {
            x1=1;
        }*/
        float y = Random.Range(0,2) == 0 ? -1:1;
        GetComponent<Rigidbody>().velocity = new Vector2(velocidade*x,velocidade*y);
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    /*
    void OnCollisionEnter(Collision batida)
    {
        if ((batida.gameObject.name=="BEsquerda") || (batida.gameObject.name=="BDireita"))
        
        transform.position = new Vector3(0, 1, 9);
        Start();

    }
    */
    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}

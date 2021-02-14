using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float Speed;
  
    public float stopingDistance;
    private Transform Target;

    // Start is called before the first frame update
    void Start()
    {
        // Está pegando o game object do palayer e depois adicionando o Transform.
        Target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
        void Update()
        {
            if(!Playervida.isDestroy)
            {
                 // Só  vai  movimentar o  inimigo  se a distancia for menor que a distância definida.
                if(Vector2.Distance(transform.position, Target.position) <  stopingDistance)
                {
                    transform.position =  Vector2.MoveTowards(transform.position, Target.position, Speed * Time.deltaTime);
                }
            }
           
        }
}

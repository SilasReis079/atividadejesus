using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogadores : MonoBehaviour
{
  
   public float Velocity,limitesuperior,limiteinferior;
    public bool Jogador1;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Jogador1 == true)
        {
            JogadorMov1();
        }
        if (Jogador1 == false)
        {
            JogadorMov2();
        }


    }
    public void JogadorMov1()
    {
        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, limiteinferior, limitesuperior));
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * Velocity * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * Velocity * Time.deltaTime);
        }


    }
    public void JogadorMov2()
    {
        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, limiteinferior, limitesuperior));
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * Velocity * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * Velocity * Time.deltaTime);
        }


    }
}

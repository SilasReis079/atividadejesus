using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolinha : MonoBehaviour
{
    public float velocidadebolinha;
    public Rigidbody2D rbBolinha;
    // Start is called before the first frame update
    void Start()
    {
        movimentacaoBolinha();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void movimentacaoBolinha()
    {
        rbBolinha.velocity = new Vector2(velocidadebolinha, velocidadebolinha) * Time.deltaTime;
    }
}
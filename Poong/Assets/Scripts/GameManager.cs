using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI pontuacao;
    public float Jogador1;
    public float Jogador2;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
            pontuacao.text = Jogador1 + "X" + Jogador2;
    }
    public void pontuacaoJg1()
    {
        Jogador1++;
    }
    public void pontuacaoJg2()
    {
        Jogador2++;
    }
}
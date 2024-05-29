using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolJogador2 : MonoBehaviour
{
    private GameManager gM;
    // Start is called before the first frame update
    void Start()
    {
        gM = FindObjectOfType(typeof(GameManager)) as GameManager;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bolinha"))
        {
            gM.pontuacaoJg1();
            collision.gameObject.transform.position = Vector3.zero;
        }
    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class GolJogador1 : MonoBehaviour
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
            gM.pontuacaoJg2();
            collision.gameObject.transform.position = Vector3.zero;
        }
    }
}

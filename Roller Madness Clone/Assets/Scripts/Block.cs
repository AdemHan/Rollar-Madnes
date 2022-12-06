using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    // Start is called before the first frame update
    private bool isColided = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(isColided == false && collision.gameObject.tag == "Player")
        {
            print(collision.gameObject.name);
            GetComponent<MeshRenderer>().material.color = Color.red;  // çarptýðýmýz nesnenin rengini deðiþtirmek için MeshRenderer'dan material ve rengi getirdik. en Son kýrmýzý olarak eþitledik.
            ScoreManager scoreManager = FindObjectOfType<ScoreManager>();  // ScoreManager bulundu
            scoreManager.score--; // score 1 azaltýldý
            isColided = true;  // bir kez çalýþsýn diye sonda true yaptýk
        }
        
    }
}

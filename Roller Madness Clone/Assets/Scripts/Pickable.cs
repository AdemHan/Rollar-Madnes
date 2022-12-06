using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : MonoBehaviour
{
    public int scoreAmount = 2;
    [SerializeField] private GameObject deadEffect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)  // is trigger a��ksa other yerine nesnemizi koyacak
    {
        if (other.gameObject.tag == "Player")  // tag player ise bu i�lem yap�lacak
        {
            ScoreManager scoreManager = FindObjectOfType<ScoreManager>(); // score manager� bulacak.
            scoreManager.score += scoreAmount; // score artt�rma i�lemi yap�l�yor
            Destroy(gameObject);
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") // tag player ise bu i�lem yap�lacak
        {
            ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
            scoreManager.score += scoreAmount;
            Destroy(gameObject); // gameobject coin'e tak�l� oldu�u i�in coin yok edilecek.
        }
        
    }
    private void OnDisable()
    {
        Instantiate(deadEffect, transform.position, transform.rotation);
    }
}

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
    private void OnTriggerEnter(Collider other)  // is trigger açýksa other yerine nesnemizi koyacak
    {
        if (other.gameObject.tag == "Player")  // tag player ise bu iþlem yapýlacak
        {
            ScoreManager scoreManager = FindObjectOfType<ScoreManager>(); // score managerý bulacak.
            scoreManager.score += scoreAmount; // score arttýrma iþlemi yapýlýyor
            Destroy(gameObject);
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") // tag player ise bu iþlem yapýlacak
        {
            ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
            scoreManager.score += scoreAmount;
            Destroy(gameObject); // gameobject coin'e takýlý olduðu için coin yok edilecek.
        }
        
    }
    private void OnDisable()
    {
        Instantiate(deadEffect, transform.position, transform.rotation);
    }
}

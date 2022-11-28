using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Transform target;
    [SerializeField] private float speed = 3f;
    [SerializeField] private float stopDistance = -1000f;
    void Start()
    {
        target = GameObject.FindWithTag("Player").GetComponent<Transform>(); // player adlý tag i bulduk ve pozisyonunu çektik.
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null) // null referance hatasi almamak icin targetin null olmmadigi zamanlarda calismasini sagladim.
        {
            transform.LookAt(target);
            float distance = Vector3.Distance(transform.position, target.position);
            if (distance > stopDistance)  // mesafe durma mesafesinden büyükse yaklaþmaya devam ediyor   
            {
                transform.position += transform.forward * speed * Time.deltaTime; // bizi takip eden düþmanýn hýzýný ayarlýyoruz. speed inspectordan deðiþebiliyor.
            }
        }
        
    }
    private void OnCollisionEnter(Collision collision)  // fiziksel bir etkileþim olduðundan OnCollisionEnter kullandýk
    {
        if(collision.gameObject.tag == "Player")  //çarptýðýmýz nesnenin tagi Player ise calisir
        {
            Destroy(collision.gameObject);  // carptigimiz nesne yok olur
            TimeManager timeManager = FindObjectOfType<TimeManager>();
            timeManager.gameOver = true;  
        }
    }
}

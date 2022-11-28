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
        target = GameObject.FindWithTag("Player").GetComponent<Transform>(); // player adl� tag i bulduk ve pozisyonunu �ektik.
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null) // null referance hatasi almamak icin targetin null olmmadigi zamanlarda calismasini sagladim.
        {
            transform.LookAt(target);
            float distance = Vector3.Distance(transform.position, target.position);
            if (distance > stopDistance)  // mesafe durma mesafesinden b�y�kse yakla�maya devam ediyor   
            {
                transform.position += transform.forward * speed * Time.deltaTime; // bizi takip eden d��man�n h�z�n� ayarl�yoruz. speed inspectordan de�i�ebiliyor.
            }
        }
        
    }
    private void OnCollisionEnter(Collision collision)  // fiziksel bir etkile�im oldu�undan OnCollisionEnter kulland�k
    {
        if(collision.gameObject.tag == "Player")  //�arpt���m�z nesnenin tagi Player ise calisir
        {
            Destroy(collision.gameObject);  // carptigimiz nesne yok olur
            TimeManager timeManager = FindObjectOfType<TimeManager>();
            timeManager.gameOver = true;  
        }
    }
}

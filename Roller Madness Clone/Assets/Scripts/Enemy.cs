using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Transform target;
    [SerializeField] private float speed = 3f;
    [SerializeField] private float stopDistance = 1f;
    void Start()
    {
        target = GameObject.FindWithTag("Player").GetComponent<Transform>(); // player adl� tag i bulduk ve pozisyonunu �ektik.
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
        float distance = Vector3.Distance(transform.position, target.position);
        if(distance > stopDistance)  // mesafe durma mesafesinden b�y�kse yakla�maya devam ediyor   
        {
            transform.position += transform.forward * speed * Time.deltaTime; // bizi takip eden d��man�n h�z�n� ayarl�yoruz. speed inspectordan de�i�ebiliyor.
        }
    }
}

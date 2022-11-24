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
        target = GameObject.FindWithTag("Player").GetComponent<Transform>(); // player adlý tag i bulduk ve pozisyonunu çektik.
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
        float distance = Vector3.Distance(transform.position, target.position);
        if(distance > stopDistance)  // mesafe durma mesafesinden büyükse yaklaþmaya devam ediyor   
        {
            transform.position += transform.forward * speed * Time.deltaTime; // bizi takip eden düþmanýn hýzýný ayarlýyoruz. speed inspectordan deðiþebiliyor.
        }
    }
}

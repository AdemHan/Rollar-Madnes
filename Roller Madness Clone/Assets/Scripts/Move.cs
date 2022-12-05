using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Vector3 movement;
    [SerializeField] private float speed = 10f;
    private Rigidbody rigidbody;
    private TimeManager timeManager;
    
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        timeManager = FindObjectOfType<TimeManager>();
        
    }

    
    void Update()
    {
        if (timeManager.gameOver == false && timeManager.gameFinished == false )  // oyunu kaybetmemi�sek ve kazanmam��sak oyuncu hareket etmeye devam eder.
        {
            MoveThePlayer();
        }
        if (timeManager.gameOver || timeManager.gameFinished)  // oyunu kazanm��sak veya kaybetmi�sek takip etmez
        {
            rigidbody.isKinematic = true;  // kinematik a��l�rsa hareket i�levi kaybolur.
        }
    }

    private void MoveThePlayer()
    {
        float x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;  //X de�i�kenini horizontal eksende kayd�rmak i�in atama yapt�k
        float z = Input.GetAxis("Vertical") * speed * Time.deltaTime;   //z de�i�kenini vertical eksende kayd�rmak i�in atama yapt�k
        movement = new Vector3(x, 0f, z);
        //transform.position += movement;
        rigidbody.AddForce(movement);  // �znemizin hareketini fiziksel olarak sa�lamak i�in addForce kullanarak �zerine kuvvet uygulad�k
    }
}

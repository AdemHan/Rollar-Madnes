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
        if (timeManager.gameOver == false && timeManager.gameFinished == false )  // oyunu kaybetmemiþsek ve kazanmamýþsak oyuncu hareket etmeye devam eder.
        {
            MoveThePlayer();
        }
        if (timeManager.gameOver || timeManager.gameFinished)  // oyunu kazanmýþsak veya kaybetmiþsek takip etmez
        {
            rigidbody.isKinematic = true;  // kinematik açýlýrsa hareket iþlevi kaybolur.
        }
    }

    private void MoveThePlayer()
    {
        float x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;  //X deðiþkenini horizontal eksende kaydýrmak için atama yaptýk
        float z = Input.GetAxis("Vertical") * speed * Time.deltaTime;   //z deðiþkenini vertical eksende kaydýrmak için atama yaptýk
        movement = new Vector3(x, 0f, z);
        //transform.position += movement;
        rigidbody.AddForce(movement);  // öznemizin hareketini fiziksel olarak saðlamak için addForce kullanarak üzerine kuvvet uyguladýk
    }
}

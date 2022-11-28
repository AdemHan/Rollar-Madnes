using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Vector3 movement;
    [SerializeField] private float speed = 10f;
    private Rigidbody rigidbody;
    
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        
    }

    
    void Update()
    {  
            MoveThePlayer();
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

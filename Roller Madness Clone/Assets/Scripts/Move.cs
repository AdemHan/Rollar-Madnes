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
        float x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;  //X deðiþkenini horizontal eksende kaydýrmak için atama yaptýk
        float z = Input.GetAxis("Vertical") * speed * Time.deltaTime;   //z deðiþkenini vertical eksende kaydýrmak için atama yaptýk
        movement = new Vector3(x, 0f, z);
        //transform.position += movement;
        rigidbody.AddForce(movement);  // öznemizin hareketini fiziksel olarak saðlamak için addForce kullanarak üzerine kuvvet uyguladýk
    }
}

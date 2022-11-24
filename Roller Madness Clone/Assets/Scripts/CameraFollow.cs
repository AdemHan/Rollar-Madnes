using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float cameraFollowSpeed = 5f; //kameranýn hýzýný belirleyen deðiþken

    private Vector3 offsetVector; // Kamera ve oyuncu arasýndaki mesafeyi tutuyor.
    

    // Start is called before the first frame update
    void Start()
    {
        offsetVector = CalculateOffset(target);  //target ýn deðerini CalculateOffset te yerine yazdýk ve çýkan sonucu offsetVector'e eþitledik.
    }

    // Update is called once per frame
    void FixedUpdate()  //diðer updatelerle çakýþýp oyunda titrememesi için update den sonra çalýþan FixedUpdate kullandýk.
    {
        MoveTheCamera();
    }

    private void MoveTheCamera()
    {
        Vector3 targetToMove = target.position + offsetVector;  // Oyuncunun konumunun üzerine aradaki mesafeyi ekliyoruz.
        transform.position = Vector3.Lerp(transform.position, targetToMove, cameraFollowSpeed * Time.deltaTime); //kameranýn yumuþak hareket etmesi için lerp kullandýk. Baþlangýç noktasýný, bitiþ noktasýný ve bu aradaki mesafeyi ne kadar sürede gideceðini belirledik.
        transform.LookAt(target.transform.position); // kamera hep topa baksýn diye lookAt içerisine topun konumunu yazdýk.
    }

    private Vector3 CalculateOffset(Transform newTarget)  // kamera ve oyuncunun arasýndaki mesafeyi hesaplayan bir metot yaptýk
    {
        return transform.position - newTarget.position;
    }
}

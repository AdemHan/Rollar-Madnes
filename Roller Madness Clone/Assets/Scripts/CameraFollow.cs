using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float cameraFollowSpeed = 5f; //kameran�n h�z�n� belirleyen de�i�ken

    private Vector3 offsetVector; // Kamera ve oyuncu aras�ndaki mesafeyi tutuyor.
    

    // Start is called before the first frame update
    void Start()
    {
        offsetVector = CalculateOffset(target);  //target �n de�erini CalculateOffset te yerine yazd�k ve ��kan sonucu offsetVector'e e�itledik.
    }

    // Update is called once per frame
    void FixedUpdate()  //di�er updatelerle �ak���p oyunda titrememesi i�in update den sonra �al��an FixedUpdate kulland�k.
    {
        MoveTheCamera();
    }

    private void MoveTheCamera()
    {
        Vector3 targetToMove = target.position + offsetVector;  // Oyuncunun konumunun �zerine aradaki mesafeyi ekliyoruz.
        transform.position = Vector3.Lerp(transform.position, targetToMove, cameraFollowSpeed * Time.deltaTime); //kameran�n yumu�ak hareket etmesi i�in lerp kulland�k. Ba�lang�� noktas�n�, biti� noktas�n� ve bu aradaki mesafeyi ne kadar s�rede gidece�ini belirledik.
        transform.LookAt(target.transform.position); // kamera hep topa baks�n diye lookAt i�erisine topun konumunu yazd�k.
    }

    private Vector3 CalculateOffset(Transform newTarget)  // kamera ve oyuncunun aras�ndaki mesafeyi hesaplayan bir metot yapt�k
    {
        return transform.position - newTarget.position;
    }
}

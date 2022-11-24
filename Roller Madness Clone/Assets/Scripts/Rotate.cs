using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Vector3 angle;  // vectorleri tek tek burda yazmak yerine angle adýnda vector3 deðiþkeni atadýk. SerializeField ile inspectordan deðiþim imkaný verdik

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(angle, Space.World);  // transform.Rotate ile dönme iþlemini yerine getirirken space.world ile eksenleri global e getirmiþ olduk
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Vector3 angle;  // vectorleri tek tek burda yazmak yerine angle ad�nda vector3 de�i�keni atad�k. SerializeField ile inspectordan de�i�im imkan� verdik

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(angle, Space.World);  // transform.Rotate ile d�nme i�lemini yerine getirirken space.world ile eksenleri global e getirmi� olduk
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public bool gameFinished = false;
    [SerializeField] private float levelFinishTime = 5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Time.time > levelFinishTime)  //süremiz oyunun bitme süresinden büyükse çalýþacak
        {
            print(Time.time);  // zamaný yazdýracak
            gameFinished = true;
            print("Next Level"); // sonraki level yazýsý basýlacak.
        }
    }
}

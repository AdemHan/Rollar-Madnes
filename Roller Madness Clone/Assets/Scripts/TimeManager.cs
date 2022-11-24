using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public bool gameFinished = false;
    public bool gameOver = false;
    [SerializeField] private float levelFinishTime = 5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Time.time > levelFinishTime && gameOver == false)  //süremiz oyunun bitme süresinden büyükse ve oyun bitmediyse 
        {
            print(Time.time);  // zamaný yazdýracak
            gameFinished = true;
            print("Next Level"); // sonraki level yazýsý basýlacak.
        }
        if (gameOver == true)
        {
            print("Restart");  // oyun bittiyse çalýþacak
        }
    }
}

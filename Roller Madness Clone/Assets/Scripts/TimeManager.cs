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
        
        if (Time.time > levelFinishTime)  //s�remiz oyunun bitme s�resinden b�y�kse �al��acak
        {
            print(Time.time);  // zaman� yazd�racak
            gameFinished = true;
            print("Next Level"); // sonraki level yaz�s� bas�lacak.
        }
    }
}

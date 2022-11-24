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
        
        if (Time.time > levelFinishTime)
        {
            print(Time.time);
            gameFinished = true;
            print("Next Level");
        }
    }
}

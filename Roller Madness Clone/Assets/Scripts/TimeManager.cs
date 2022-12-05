using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public bool gameFinished = false;
    public bool gameOver = false;
    [SerializeField] private float levelFinishTime = 5f;
    [SerializeField] private Text timeText;

    [SerializeField] private GameObject winPanel;
    [SerializeField] private GameObject losePanel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameFinished == false && gameOver == false)
        {
            UpdateTheTimer();
        }

        if (Time.timeSinceLevelLoad > levelFinishTime && gameOver == false)  //süremiz oyunun bitme süresinden büyükse ve oyun bitmediyse 
        {
            print(Time.time);  // zamaný yazdýracak
            gameFinished = true;
            winPanel.gameObject.SetActive(true);
            losePanel.gameObject.SetActive(false);
        }
        if (gameOver == true)
        {
            winPanel.gameObject.SetActive(false);
            losePanel.gameObject.SetActive(true);
        }
    }
    private void UpdateTheTimer()
    {
        timeText.text = "Time: " + (int)Time.timeSinceLevelLoad;  // text icerisine time degerini float yerine integer seklinde yazmasýný söyledik 
    }
}

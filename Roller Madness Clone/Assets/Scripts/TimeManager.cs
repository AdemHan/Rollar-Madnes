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

    [SerializeField] private List<GameObject> destroyAfterGame = new List<GameObject>();  // destroyAfterGame ad�nda bir liste haz�rlad�k 
    void Start()
    {
        destroyAfterGame.AddRange(GameObject.FindGameObjectsWithTag("Objects")); // tagi Objects olan her �eyi destroyAfterGame listesinin i�ine ekler
        destroyAfterGame.AddRange(GameObject.FindGameObjectsWithTag("Enemy")); // tagi Objects olan her �eyi destroyAfterGame listesinin i�ine ekler
    }

    // Update is called once per frame
    void Update()
    {
        if (gameFinished == false && gameOver == false)    // oyun bitmediyse 
        {
            UpdateTheTimer();   // saya� devam etsin
        }

        if (Time.timeSinceLevelLoad > levelFinishTime && gameOver == false)  //s�remiz oyunun bitme s�resinden b�y�kse ve oyun bitmediyse 
        {
            print(Time.time);  // zaman� yazd�racak
            gameFinished = true;
            winPanel.gameObject.SetActive(true);
            losePanel.gameObject.SetActive(false);
            UpdateObjectList("Objects");
            UpdateObjectList("Enemy");
            foreach (GameObject allObjects in destroyAfterGame) //destroyAfterGame i�indeki her �eyi
            {
                Destroy(allObjects);   // yok et
            }
        }
        if (gameOver == true)  // oyun bittiyse
        {
            winPanel.gameObject.SetActive(false);
            losePanel.gameObject.SetActive(true);
            UpdateObjectList("Objects");
            UpdateObjectList("Enemy");
            foreach (GameObject allObjects in destroyAfterGame)  // destroyAfterGame i�indeki her �eyi
            {
                Destroy(allObjects);  // yok et
            }
        }
    }
    private void UpdateObjectList(string tag)
    {
        destroyAfterGame.AddRange(GameObject.FindGameObjectsWithTag(tag)); // tagi Objects olan her �eyi destroyAfterGame listesinin i�ine ekler
    }
    private void UpdateTheTimer()
    {
        timeText.text = "Time: " + (int)Time.timeSinceLevelLoad;  // text icerisine time degerini float yerine integer seklinde yazmas�n� s�yledik 
    }
}

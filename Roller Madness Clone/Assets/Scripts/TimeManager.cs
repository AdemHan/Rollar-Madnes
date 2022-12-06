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

    [SerializeField] private List<GameObject> destroyAfterGame = new List<GameObject>();  // destroyAfterGame adýnda bir liste hazýrladýk 
    void Start()
    {
        destroyAfterGame.AddRange(GameObject.FindGameObjectsWithTag("Objects")); // tagi Objects olan her þeyi destroyAfterGame listesinin içine ekler
        destroyAfterGame.AddRange(GameObject.FindGameObjectsWithTag("Enemy")); // tagi Objects olan her þeyi destroyAfterGame listesinin içine ekler
    }

    // Update is called once per frame
    void Update()
    {
        if (gameFinished == false && gameOver == false)    // oyun bitmediyse 
        {
            UpdateTheTimer();   // sayaç devam etsin
        }

        if (Time.timeSinceLevelLoad > levelFinishTime && gameOver == false)  //süremiz oyunun bitme süresinden büyükse ve oyun bitmediyse 
        {
            print(Time.time);  // zamaný yazdýracak
            gameFinished = true;
            winPanel.gameObject.SetActive(true);
            losePanel.gameObject.SetActive(false);
            UpdateObjectList("Objects");
            UpdateObjectList("Enemy");
            foreach (GameObject allObjects in destroyAfterGame) //destroyAfterGame içindeki her þeyi
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
            foreach (GameObject allObjects in destroyAfterGame)  // destroyAfterGame içindeki her þeyi
            {
                Destroy(allObjects);  // yok et
            }
        }
    }
    private void UpdateObjectList(string tag)
    {
        destroyAfterGame.AddRange(GameObject.FindGameObjectsWithTag(tag)); // tagi Objects olan her þeyi destroyAfterGame listesinin içine ekler
    }
    private void UpdateTheTimer()
    {
        timeText.text = "Time: " + (int)Time.timeSinceLevelLoad;  // text icerisine time degerini float yerine integer seklinde yazmasýný söyledik 
    }
}

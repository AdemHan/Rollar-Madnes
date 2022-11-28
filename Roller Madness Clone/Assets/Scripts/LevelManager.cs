using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RestartLevel()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene);  // aktif olan leveli yeniden baþlatmaya yarar.
    }

    public void LoadNextLevel()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;   // aktif olan sahne numarasýnýn üzerine 1 ekler ve sonraki levele geçer 
        int sceneIndex = SceneManager.sceneCountInBuildSettings - 1;  // sahnenin numarasýný almaya yarar. 1 azaltmamýzýn nedeni sceneCountInBuildSettings in 1 den baþlamasý. Fakat bizim indexlerimiz 0 dan baþlýyor. Bu yüzden 1 azaltmak gerekiyor.

        if (nextSceneIndex <= sceneIndex)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
        if (nextSceneIndex > sceneIndex)
        {
            SceneManager.LoadScene(0);
        }
    }
}

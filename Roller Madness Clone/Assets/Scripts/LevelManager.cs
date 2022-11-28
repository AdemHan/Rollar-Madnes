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
        SceneManager.LoadScene(currentScene);  // aktif olan leveli yeniden ba�latmaya yarar.
    }

    public void LoadNextLevel()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;   // aktif olan sahne numaras�n�n �zerine 1 ekler ve sonraki levele ge�er 
        int sceneIndex = SceneManager.sceneCountInBuildSettings - 1;  // sahnenin numaras�n� almaya yarar. 1 azaltmam�z�n nedeni sceneCountInBuildSettings in 1 den ba�lamas�. Fakat bizim indexlerimiz 0 dan ba�l�yor. Bu y�zden 1 azaltmak gerekiyor.

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

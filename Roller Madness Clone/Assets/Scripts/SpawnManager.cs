using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] objects;
    [SerializeField] private float spawnRate = 5f;          // kac saniyede bir spawn olacagini tutuyor
    [SerializeField] private Transform[] spawnPositions;  // Spawn noktalarýný dizi kullanarak belirledik
    private TimeManager timeManager;
    private float nextSpawnTime = 0f;  // oyunun basindan itibaren calismaya baslamasi icin 0 verdik
    void Start()
    {
        timeManager = FindObjectOfType<TimeManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeSinceLevelLoad > nextSpawnTime && timeManager.gameOver == false && timeManager.gameFinished == false)  // oyun ici zaman nextspawntime dan büyükse calisir
        {
            nextSpawnTime += spawnRate;  //spawnRate yani spawn araligi inspector üzerinden de degisebilir.
            SpawnObject(objects[RandomObjectNumber()], spawnPositions[RandomSpawnNumber()]);  // spawn edilecek nesnenin adý ve transform bilgisi
            print("spawned");
        }
    }
    private void SpawnObject(GameObject objectToSpawn, Transform newTransform)
    {
        Instantiate(objectToSpawn, newTransform.position, newTransform.rotation);     // Instantiate spawn etmeye yarar. SpawnManagerin konumuna ve rotasyonuna spawn ediyoruz
    }

    private int RandomSpawnNumber()
    {
        return Random.Range(0, spawnPositions.Length);     //Belirtilen aralýkta spawn edilecek dizi elemanýndaki sýrayý belirtir
    }

    private int RandomObjectNumber()
    {
        return Random.Range(0, objects.Length);
    }
}

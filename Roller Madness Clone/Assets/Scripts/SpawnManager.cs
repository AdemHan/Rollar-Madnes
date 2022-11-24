using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject coinPrefab;   // coini icine koymamizi saglar
    [SerializeField] private GameObject enemyPrefab;  // enemyi icine koymamizi saglar
    [SerializeField] private float spawnRate = 5f;          // kac saniyede bir spawn olacagini tutuyor
    
    private float nextSpawnTime = 0f;  // oyunun basindan itibaren calismaya baslamasi icin 0 verdik
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawnTime)  // oyun ici zaman nextspawntime dan büyükse calisir
        {
            nextSpawnTime += spawnRate;  //spawnRate yani spawn araligi inspector üzerinden de degisebilir.
            SpawnObject(coinPrefab, transform);
            print("spawn");
        }
    }
    private void SpawnObject(GameObject objectToSpawn, Transform newTransform)
    {
        Instantiate(objectToSpawn, newTransform.position, newTransform.rotation);     // Instantiate spawn etmeye yarar. SpawnManagerin konumuna ve rotasyonuna spawn ediyoruz
    }
}

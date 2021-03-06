using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggSpawner : MonoBehaviour
{
    public GameObject[] EggPrefab;
    // public float SpawnTime = 2f;
    [SerializeField]
    float spawnPosMinX;
    [SerializeField]
    float spawnPosMaxX;
    [SerializeField]
    float spawnPosY;
    public delegate void MyDelegate();
    public static MyDelegate myDelegate;
    [SerializeField]
    float timeToNextStage = 30f;
    // Start is called before the first frame update
    void Start()
    {
        timeToNextStage = Time.time + timeToNextStage;
        myDelegate = SpawnEgg;
    }

    // Update is called once per frame
    void Update()
    {
        if( Time.time > timeToNextStage){
            myDelegate += SpawnEgg;
            timeToNextStage = Time.time + timeToNextStage;
        }
    }

    void SpawnEgg()
    {
        int ran = 0;
        if (EggPrefab.Length > 1 && Random.Range(0, 100) < 50)
        {
            ran = Random.Range(1, EggPrefab.Length);
        }
        float ranPosX = Random.Range(spawnPosMinX, spawnPosMaxX);
        Vector3 pos = new Vector3(ranPosX, spawnPosY, 0);
        Instantiate(EggPrefab[ran], pos, Quaternion.identity);
    }

    
}

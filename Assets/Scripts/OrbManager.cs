using Unity.Mathematics;
using UnityEngine;

public class OrbManager : MonoBehaviour
{
    public GameObject orbPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        for (int i = 0; i < 30; i++)
        {
            //Creating position variable
            Vector3 spawnPosition = new Vector3(UnityEngine.Random.Range(-50,50), 0, UnityEngine.Random.Range(-50,50));

            //instantiate the orbs
            Instantiate(orbPrefab, spawnPosition, quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

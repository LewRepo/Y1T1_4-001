using UnityEngine;
using Unity.Mathematics;

public class Asteroid : MonoBehaviour
{

    public GameObject AsteroidPreFab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        for (int i = 0; i < 60; i++)
        {
            Vector3 spawnPosition = new Vector3(UnityEngine.Random.Range(-50, 50), 0, UnityEngine.Random.Range(-50, 50));

            Instantiate(AsteroidPreFab, spawnPosition, quaternion.identity);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay(Collision collision)
    {

        if (collision.gameObject.CompareTag("Danger"))
        {
            Debug.Log("Should have paid closer attention to the simulations!");
            Destroy(gameObject);
        }
    }

}

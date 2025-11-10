using Unity.VisualScripting;
using UnityEngine;

public class Orb : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionStay(Collision collision) {

        if (collision.gameObject.CompareTag("Player")) {
            collision.gameObject.GetComponent<PlayerController>().orbs++;
            Debug.Log("WE HAVE ORBS: " + collision.gameObject.GetComponent<PlayerController>().orbs);
            Destroy(gameObject);
        }
    }
}


using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{

    public int speed;
    public int orbs;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //The movement code
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        //Debug.Log("h is " + h + " . and V is " + v);

        transform.Translate(new Vector3(h * Time.deltaTime * speed, 0, v * Time.deltaTime * speed));

        // ORBS COUNT (MOVED TO ORB.CS)
       

    }
}

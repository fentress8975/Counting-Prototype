using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pusher : MonoBehaviour
{
    public Slider powerSlider;
    public float power = 60;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name != "Block Pusher") 
        {
            power = powerSlider.value;
        }
            
    }

   

    

    private void OnTriggerStay(Collider other)
    {
        if (gameObject.name == "Block Pusher")
        {
            Rigidbody otherRB;
            otherRB = other.GetComponent<Rigidbody>();
            otherRB.AddForce(Vector3.up * power, ForceMode.Impulse);
            Debug.Log("Ball Block: " + power);
        }
        if (Input.GetKey(KeyCode.Space) && gameObject.name!= "Block Pusher")
        {
            if (other.gameObject.CompareTag("Ball") )
            {
                Rigidbody otherRB;
                otherRB = other.GetComponent<Rigidbody>();
                otherRB.AddForce(Vector3.up * power, ForceMode.Impulse);
                Debug.Log("Ball Push: " + power);
            }
        }
    }

}

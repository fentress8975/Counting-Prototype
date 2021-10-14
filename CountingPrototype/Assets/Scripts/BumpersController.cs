using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumpersController : MonoBehaviour
{
    public GameObject bumperL;
    public GameObject bumperR;


    private Rigidbody bumperLRB;
    private Rigidbody bumperRRB;
    private float rotationRestriction = 45f;
    // Start is called before the first frame update
    void Start()
    {
        bumperLRB = GetComponent<Rigidbody>();
        bumperRRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

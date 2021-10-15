using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumpersController : MonoBehaviour
{
    public GameObject bumperL;
    public GameObject bumperR;


  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PushBack();
        float horizontalInput = Input.GetAxis("Horizontal");
        if (horizontalInput<0)
        {
            float degrees = 40;
            Vector3 to = new Vector3(degrees, 0, 180);
            
            //bumperL.transform.eulerAngles = Vector3.Lerp(bumperL.transform.rotation.eulerAngles, to, Time.deltaTime * 2);
            bumperL.transform.rotation = Quaternion.RotateTowards(bumperL.transform.rotation, Quaternion.Euler(to), Time.deltaTime *1000f);

        }
        else if (horizontalInput>0)
        {
            float degrees = 40;
            Vector3 to = new Vector3(degrees, 0, 0);
            //bumperR.transform.eulerAngles = Vector3.Lerp(bumperR.transform.rotation.eulerAngles, to, 0.6f);
            bumperR.transform.rotation = Quaternion.RotateTowards(bumperR.transform.rotation, Quaternion.Euler(to), Time.deltaTime * 1000f);
        }
    }

    void PushBack()
    {
        Vector3 restrictionL = new Vector3(90, 0, 180);
        Vector3 restrictionR = new Vector3(0, 0, 0);
        bumperL.transform.rotation = Quaternion.RotateTowards(bumperL.transform.rotation, Quaternion.Euler(restrictionL), Time.deltaTime * 500f);
        //bumperL.transform.eulerAngles = Vector3.Lerp(bumperL.transform.rotation.eulerAngles, restrictionL, 2f);
        bumperR.transform.rotation = Quaternion.RotateTowards(bumperR.transform.rotation, Quaternion.Euler(restrictionR), Time.deltaTime * 500f);

    }
}

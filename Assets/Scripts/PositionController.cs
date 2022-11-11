using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionController : MonoBehaviour
{

    //Components 
    public GameObject myDotTransform;
    //Values of the Controller
    public float pitch;//vertical rotation
    public float yaw; //horizontal //Go for -180 to 180 range
    public float roll;//sideways rotation

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(pitch>25)
        {
            myDotTransform.transform.position = new Vector3(myDotTransform.transform.position.x, 4.35f, myDotTransform.transform.position.z);
        }

        else if (pitch < -25)
        {
            myDotTransform.transform.position = new Vector3(myDotTransform.transform.position.x, -2.33f, myDotTransform.transform.position.z);
        }

        else 
        {
            myDotTransform.transform.position = new Vector3(myDotTransform.transform.position.x, 1.04f, myDotTransform.transform.position.z);
        }

        if(yaw>25)
        {
            myDotTransform.transform.position = new Vector3(3.56f, myDotTransform.transform.position.y, myDotTransform.transform.position.z);
        }

        else if (yaw < -25)
        {
            myDotTransform.transform.position = new Vector3(-3.74f, myDotTransform.transform.position.y, myDotTransform.transform.position.z);
        }

        else
        {
            myDotTransform.transform.position = new Vector3(-0.1f, myDotTransform.transform.position.y, myDotTransform.transform.position.z);
        }

  
    }
}

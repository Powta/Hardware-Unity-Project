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

    //bools
    public bool isBlocking;

    //isBlocking Text
    public GameObject isBlockingTrue;
    public GameObject isBlockingFalse;

    //Reading Arduino
    public GameObject arduinoInfo;
    public float aPitch;//Arduino
    public float aYaw; //Arduino
    public float aRoll;//Arduino

    // Start is called before the first frame update
    void Start()
    {
        isBlocking = false;
    }

    // Update is called once per frame
    void Update()
    {
       
        //aPitch = float.Parse((arduinoInfo.GetComponent<ReadArduino>().stringPitch));
        //aRoll= float.Parse((arduinoInfo.GetComponent<ReadArduino>().stringRoll)); 
        //aYaw= float.Parse((arduinoInfo.GetComponent<ReadArduino>().stringYaw));

        aPitch = float.Parse((arduinoInfo.GetComponent<ReadArduino>().stringRoll));
        aRoll = float.Parse((arduinoInfo.GetComponent<ReadArduino>().stringPitch));
        aYaw = float.Parse((arduinoInfo.GetComponent<ReadArduino>().stringYaw));

        pitch = aPitch;
        roll = aRoll;
        yaw = aYaw;
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

        if(roll>15)
        {
            myDotTransform.transform.position = new Vector3(3.56f, myDotTransform.transform.position.y, myDotTransform.transform.position.z);
        }

        else if (roll < -15)
        {
            myDotTransform.transform.position = new Vector3(-3.74f, myDotTransform.transform.position.y, myDotTransform.transform.position.z);
        }

        else
        {
            myDotTransform.transform.position = new Vector3(-0.1f, myDotTransform.transform.position.y, myDotTransform.transform.position.z);
        }

  
        //is Blocking
        if(isBlocking)
        {
            isBlockingTrue.SetActive(true);
            isBlockingFalse.SetActive(false);
        }
        else
        {
            isBlockingTrue.SetActive(false);
            isBlockingFalse.SetActive(true);
        }
    }
}

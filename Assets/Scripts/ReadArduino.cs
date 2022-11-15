using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadArduino : MonoBehaviour
{
    public SerialController serialController;
    public GameObject positionController;
    // Initialization
    void Start()
    {
        serialController = GameObject.Find("SerialController").GetComponent<SerialController>();
    }

    // Executed each frame
    void Update()
    {
        string message = serialController.ReadSerialMessage();

        if (message == null)
            return;
        else if(message.Contains("LED ON"))
        {
            positionController.GetComponent<PositionController>().isBlocking = true;
        }

        else if (message.Contains("LED OFF"))
        {
            positionController.GetComponent<PositionController>().isBlocking = false;
        }

        // Check if the message is plain data or a connect/disconnect event.
        if (ReferenceEquals(message, SerialController.SERIAL_DEVICE_CONNECTED))
            Debug.Log("Connection established");
        else if (ReferenceEquals(message, SerialController.SERIAL_DEVICE_DISCONNECTED))
            Debug.Log("Connection attempt failed or disconnection detected");
        else
            Debug.Log("Message arrived: " + message);
    }
}

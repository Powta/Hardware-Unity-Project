using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    string myTestString;
    string myCutString;
    bool testTrue;
    // Start is called before the first frame update
    void Start()
    {
        testTrue = true;
        myTestString = "testing";
        myCutString = myTestString.Substring(4);
        Debug.Log(myCutString);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_CallMain : MonoBehaviour
{

    static Script_CallMain instance;
    public static Script_CallMain Instance
    {
        get
        {
            if (instance == null)
            {
                instance = (Script_CallMain)FindObjectOfType(typeof(Script_CallMain));
            }
            return instance;
        }
    }

    public void Show_1()
    {
        print("Show_1");
    }

    private void Show_2()
    {
        print("Show_2");
    }

    public void Show_3()
    {
        print("Show_3");
    }

}

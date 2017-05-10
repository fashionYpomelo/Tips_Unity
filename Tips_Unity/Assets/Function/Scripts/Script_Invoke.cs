using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Invoke : MonoBehaviour
{

	// Use this for initialization
	void Start () {
        Invoke("Show", 1.0f);
        InvokeRepeating("ShowAll", 2.0f, 1.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Show()
    {
        print("一秒后只调用一次");
    }
    void ShowAll()
    {
        print("2秒后调用，每隔1秒调用");
    }
}

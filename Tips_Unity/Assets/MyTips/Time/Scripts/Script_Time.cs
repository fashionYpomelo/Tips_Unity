using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Time : MonoBehaviour {

    private float showRate = 2f;
    private float nextShow=0;
	void Start () {
		
	}
	
	// Update is called once per frame
    void Update()
    {
        if (Time.time > nextShow)
        {
            nextShow = Time.time + showRate;
            //Time.time 就是从0开始
            print("show "+nextShow);
        }

    }
}

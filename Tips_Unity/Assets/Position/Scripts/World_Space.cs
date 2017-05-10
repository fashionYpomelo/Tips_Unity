using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World_Space : MonoBehaviour {

	// Use this for initialization
	void Start () {
        ShowPosition();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void ShowPosition()
    {
        Debug.Log("World Space  " + this.transform.position);//物体当前世界坐标
        //我们在场景中添加物体（如：Cube），他们都是以世界坐标显示在场景中的。transform.position可以获得该位置坐标。
    }
}

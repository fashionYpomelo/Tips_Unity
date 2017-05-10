using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screen_Space : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0)) { ShowPosition(); }
	}
    void ShowPosition()
    {
        Debug.Log("Screen Space  " + Input.mousePosition);//鼠标点击的屏幕坐标
        //以像素来定义的，以屏幕的左下角为（0，0）点，右上角为（Screen.width，Screen.height），Z的位置是以相机的世界单位来衡量的。
        //注：鼠标位置坐标属于屏幕坐标，Input.mousePosition可以获得该位置坐标，手指触摸屏幕也为屏幕坐标，Input.GetTouch(0).position可以获得单个手指触摸屏幕坐标。
    }
}

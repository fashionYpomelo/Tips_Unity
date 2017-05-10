using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUI_Space : MonoBehaviour
{
    public Texture buttonTexture;
    private int repeatTime = 0;
    private string info = "文本显示";

    public Texture img;     //图片    
    private Vector2 pos;    //储存鼠标的位置坐标 
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnGUI()
    {
        // 文本显示
        GUI.Label(new Rect(50, 200, 200, 50), info);

        // 第一个文字按钮
        GUI.color = Color.yellow;  //按钮文字颜色  
        GUI.backgroundColor = Color.red; //按钮背景颜色

        if (GUI.Button(new Rect(50, 250, 200, 30), "Button1"))
        {
            info = "按下了Button1";
        }

        // 第二个图片按钮
        GUI.color = Color.white;  //按钮文字颜色  
        GUI.backgroundColor = Color.green; //按钮背景颜色
        if (GUI.Button(new Rect(50, 300, 128, 64), buttonTexture))
        {
            info = "按下了Button2";
        }

        // 持续按下的按钮
        if (GUI.RepeatButton(new Rect(50, 400, 200, 30), "按钮按下中"))
        {
            info = "按钮按下中的时间：" + repeatTime;
            repeatTime++;
        }

        //鼠标左击，获取当前鼠标的位置         

        if (Input.GetMouseButton(1))
        {
            pos = Input.mousePosition;
        }
        //绘制图片        
        GUI.DrawTexture(new Rect(pos.x, Screen.height - pos.y, 100, 100), img);
    }
}

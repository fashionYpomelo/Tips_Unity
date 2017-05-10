using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_Position : MonoBehaviour
{

    //场景的相机，拖放进来        

    public Camera camera;

    //场景的物体        



    void Start()
    {

        //初始化        



    }

    void Update()
    {


       if(Input.GetMouseButton(0))
       {

            print("物体世界坐标" +transform.position);

            print("鼠标屏幕坐标" + Input.mousePosition);

            print("物体世界坐标→屏幕坐标" + camera.WorldToScreenPoint(transform.position));

            print("鼠标屏幕坐标→视口坐标" + camera.ScreenToViewportPoint(Input.mousePosition));

            print("物体世界坐标→视口坐标" + camera.WorldToViewportPoint(transform.position));

       }

    }
}

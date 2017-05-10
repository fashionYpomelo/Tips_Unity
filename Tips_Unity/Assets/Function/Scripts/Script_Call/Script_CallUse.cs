using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_CallUse : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Script_CallMain.Instance.Show_1();
            //第一种，被调用脚本函数为static类型，调用时直接用 脚本名.函数名()。
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            GameObject.Find("Main_Obj").SendMessage("Show_2");
            //第二种，GameObject.Find("脚本所在物体名").SendMessage("函数名"); 
            //此种方法可以调用public和private类型函数
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            GameObject.Find("Main_Obj").GetComponent<Script_CallMain>().Show_3();
            //第三种，GameObject.Find("脚本所在物体名").GetComponent<脚本名>().函数名();
            //此种方法只可以调用public类型函数
        }
	}
}

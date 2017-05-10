using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Coroutine : MonoBehaviour {


	void Start () {
        StartCoroutine(first());//开始协程
        StartCoroutine(last());//开始协程
	}
	
	void Update () {
		if(Input.GetKeyDown(KeyCode.S)){
            StopCoroutine("first");//结束first的协程
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            StopAllCoroutines();//关闭所有协程
        }
	}

    IEnumerator first()
    {
        yield return new WaitForSeconds(2.0f);
        print("first    2秒后显示");
        //2秒后显示
        yield return new WaitForSeconds(3.0f);
        print("first    3秒后显示");
        //再等3秒后显示
    }

    IEnumerator last()
    {
        yield return new WaitForSeconds(5.0f);
        print("last     5秒后显示");
    }

    /* 在Unity3D中，使用StartCoroutine(string methodName)和StartCoroutine(IEnumerator routine)都可以开启一个线程。
     * 区别在于使用字符串作为参数可以开启线程并在线程结束前终止线程，
     * 相反使用IEnumerator 作为参数只能等待线程的结束而不能随时终止(除非使用StopAllCoroutines()方法)；
     * 另外使用字符串作为参数时，开启线程时最多只能传递一个参数，并且性能消耗会更大一点，
     * 而使用IEnumerator 作为参数则没有这个限制。*/
}

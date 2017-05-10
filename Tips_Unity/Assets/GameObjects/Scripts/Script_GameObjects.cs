using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_GameObjects : MonoBehaviour
{

    public GameObject A;
    public GameObject B;
    void Start()
    {
        Show();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Show()
    {
        print("计算A B两物体之间的距离:    " + Vector3.Distance(A.transform.position, B.transform.position));
        print("计算A B两物体之间的角度:    " + Vector3.Angle(A.transform.forward, B.transform.forward));
        print("计算A B两物体之间的向量:    " + (A.transform.position - B.transform.position).normalized);
    }
}

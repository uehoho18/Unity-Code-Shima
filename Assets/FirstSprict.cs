using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstSprict : MonoBehaviour
{
    //  変数定数
    void Start()
    {
        string say = "Hello world"; //代入
        say = "tokyo";
        Debug.Log(say);

        const string sayConst = "Hello world2"; //代入
        Debug.Log(say);

    }

    
    void Update()
    {
    }

}

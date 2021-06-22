using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Boss
{
    private int mp = 53;          // MP(魔力)
    

    // 攻撃用の関数
    public void Magic()
    {
        if(mp >= 5)
        {
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp);
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない");
        }
    }

    // 防御用の関数
  

}


public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        
        // 配列を初期化する
        int[] array = { 10, 30, 60, 80, 100 };

        Boss wizard = new Boss();

        // 配列の要素数のぶんだけ先頭から処理を繰り返す
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        // 配列の要素数のぶんだけ最後尾から処理を繰り返す
        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }
        for(int i = 0; i < 11; i++)
        {
            wizard.Magic();
        }
        
    }
     
    // Update is called once per frame
    void Update()
    {

    }
}
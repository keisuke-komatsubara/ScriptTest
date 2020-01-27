using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100; //体力
    private int power = 25; //攻撃力
    public int mp = 53; //魔法力

    //攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }
    //魔法用の関数
    public void Magic()
    {
        if(this.mp >= 5)
        {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }
    //防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        //残りhpを減らす
        this.hp -= damage;
    }
}

public class Test : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        int[] array = { 1, 2, 3, 4, 5 };
        //各要素を順番に表示
        for (int a = 0; a < array.Length; a++)
        {
            Debug.Log(array[a]);
        }
        //各要素を逆順に表示
        for (int b = 4; b >= 0; b--)
        {
            Debug.Log(array[b]);
        }

        //Bossクラスの変数を宣言してインスタンスを代入
        Boss boss = new Boss();

        //魔法攻撃を11回行う
        for (int i = 0; i < 11 ; i++)
        {
            boss.Magic();
        }       
    }	
	// Update is called once per frame
	void Update () {
		
	}
}

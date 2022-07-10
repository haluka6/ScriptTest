using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;          // 体力
    private int power = 25; // 攻撃力
    private int mp = 53; // mp

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log( this.power + "のダメージを与えた" );
    }

    // 防御用の関数
    public  void Defence(int damage)
    {
        Debug.Log( damage+"のダメージを受けた" );
        // 残りhpを減らす
        this.hp -= damage;
    }

    // 魔法用の関数
    public void Magic()
    {
        if(mp >= 5)
        {
            this.mp -= 5;
            Debug.Log( "魔法攻撃をした。残りMPは"+mp+"。" );
        }
        else
        {
            Debug.Log( "MPが足りないため、魔法が使えない。" );
        }
    }
}

public class Test : MonoBehaviour
{
    // 「Hello, UnityChan」と表示する関数
    void Hello()
    {
        Debug.Log ("Hello, UnityChan");
    }

    // 「Goodbye, UnityChan」と表示する関数
    void Goodbye()
    {
        Debug.Log ("Goodbye, UnityChan");
    }

    // 「Hello」に続けて引数の文字列を表示する関数
    void HelloName(string name)
    {
        Debug.Log ("Hello, " + name);
    }

    // 「old」に続けて引数の文字列を表示する関数
    void HowOld(int old)
    {
        Debug.Log ("Old, " + old);
    }

    // 第一引数と第二引数の値を足した値を返す関数
    int Add(int a, int b, int c)
    {
        // 第一引数と第二引数の値を足して、変数cに代入する
        int d = a + b + c;
        // 変数cを呼び出し元の関数に返す
        return d;
    }

    // Start is called before the first frame update
    void Start()
    {
        // 要素数5の配列を初期化する
        int[] array = new int[5];

        // 配列の各要素に値を代入する
        array [0] = 6;
        array [1] = 12;
        array [2] = 53;
        array [3] = 11;
        array [4] = 833;

        // 配列の要素をすべて表示する
        Debug.Log ("順番に表示");
        for (int i = 0; i < 5; i++)
        {
            Debug.Log (array [i]);
        }

        // 配列の要素をすべて表示する
        Debug.Log ("逆順に表示");
        for (int i = 4; i > -1; i--)
        {
            Debug.Log (array [i]);
        }



        // Hello関数を呼び出す
        Hello ();
        Goodbye();

        // HelloName関数に「Unity」という引数を渡す
        HelloName ("Unity");

        // HelloName関数に「Unity」という引数を渡す
        HowOld (22);

        // Add関数に「3」と「6」の引数を渡し、返り値をnum変数に代入する
        int num = Add (3, 6, 9);
        // numを表示する
        Debug.Log (num);

        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss ();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);

        Boss midboss = new Boss ();

        lastboss.Defence(9);

        // 魔法を10回繰り出す
        for (int i = 0; i < 11; i++)
        {
            lastboss.Magic();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

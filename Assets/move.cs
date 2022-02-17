using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//UIを使うときのおまじない、忘れずに書く

public class move : MonoBehaviour
{

    GameObject player;
    //  動かしたいプレイヤー
    bool right = false;
    //  右ボタンを押しているかの真偽値
    bool left = false;
    //  左ボタンを押しているかの真偽値
    bool up = false;
    bool down = false;
    bool high = false;
    bool low = false;
    bool rt = false;
    bool lt = false;
    bool big = false;
    bool sml = false;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (right) goright();//右に動かすためのメソッドを呼び出す

        if (left) goleft();//左に動かすためのメソッドを呼び出す

        if (up) goup();//前に動かすためのメソッドを呼び出す

        if (down) godown();//後に動かすためのメソッドを呼び出す

        if (high) gohigh();//上に動かすためのメソッドを呼び出す

        if (low) golow();//下に動かすためのメソッドを呼び出す
        
        if (rt) gort();//下に動かすためのメソッドを呼び出す

        if (lt) golt();//下に動かすためのメソッドを呼び出す

        if (big) gobig();//拡大ためのメソッドを呼び出す

        if (sml) gosml();//縮小ためのメソッドを呼び出す

    }

    public void rPushDown()
    {
        //      右ボタンを押している間
        right = true;
    }

    public void rPushUp()
    {
        //      右ボタンを押すのをやめた時
        right = false;
    }

    public void uPushDown()
    {
        //      右ボタンを押している間
        up = true;
    }

    public void uPushUp()
    {
        //      右ボタンを押すのをやめた時
        up = false;
    }

    public void lPushDown()
    {
        //      左ボタンを押している間
        left = true;
    }

    public void lPushUp()
    {
        //      左ボタンを押すのをやめた時
        left = false;
    }

    public void dPushDown()
    {
        //      右ボタンを押している間
        down = true;
    }

    public void dPushUp()
    {
        //      左ボタンを押すのをやめた時7
        down = false;
    }

    public void hPushDown()
    {
        //      右ボタンを押している間
        high = true;
    }

    public void hPushUp()
    {
        //      左ボタンを押すのをやめた時
        high = false;
    }

    public void bigPushDown()
    {
        //      右ボタンを押している間
        big = true;
    }

    public void bigPushUp()
    {
        //      左ボタンを押すのをやめた時
        big = false;
    }

    public void smlPushDown()
    {
        //      右ボタンを押している間
        sml = true;
    }

    public void smlPushUp()
    {
        //      左ボタンを押すのをやめた時
        sml = false;
    }

    public void lowPushDown()
    {
        //      右ボタンを押している間
        low = true;
    }

    public void lowPushUp()
    {
        //      左ボタンを押すのをやめた時
        low = false;
    }

    public void rtPushDown()
    {
        //      右ボタンを押している間
        rt = true;
    }

    public void rtPushUp()
    {
        //      左ボタンを押すのをやめた時
        rt = false;
    }
    public void ltPushDown()
    {
        //      右ボタンを押している間
        lt = true;
    }

    public void ltPushUp()
    {
        //      左ボタンを押すのをやめた時
        lt = false;
    }

    public void goright()
    {
        transform.position += new Vector3(1.0f * Time.deltaTime, 0, 0);
    }

    public void goleft()
    {
        transform.position += new Vector3(-1.0f * Time.deltaTime, 0, 0);
    }

    public void goup()
    {
        transform.position += new Vector3(0, 0, 1.0f * Time.deltaTime);
    }

    public void godown()
    {
        transform.position += new Vector3(0, 0, -1.0f * Time.deltaTime);
    }

    public void gohigh()
    {
        transform.position += new Vector3(0,1.0f * Time.deltaTime,0);
    }

    public void golow()
    {
        transform.position += new Vector3(0,-1.0f * Time.deltaTime, 0);
    }

    public void gort()
    {
        transform.eulerAngles += new Vector3(0, 1.0f * Time.deltaTime, 0);
    }

    public void golt()
    {
        transform.eulerAngles -= new Vector3(0, 1.0f * Time.deltaTime, 0);
    }

    public void gobig()
    {
        transform.localScale += new Vector3(1.0f * Time.deltaTime, 1.0f * Time.deltaTime, 1.0f * Time.deltaTime);
    }

    public void gosml()
    {
        transform.localScale -= new Vector3(1.0f * Time.deltaTime, 1.0f * Time.deltaTime, 1.0f * Time.deltaTime);
    }
}
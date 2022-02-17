using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//UI���g���Ƃ��̂��܂��Ȃ��A�Y�ꂸ�ɏ���

public class move : MonoBehaviour
{

    GameObject player;
    //  �����������v���C���[
    bool right = false;
    //  �E�{�^���������Ă��邩�̐^�U�l
    bool left = false;
    //  ���{�^���������Ă��邩�̐^�U�l
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
        if (right) goright();//�E�ɓ��������߂̃��\�b�h���Ăяo��

        if (left) goleft();//���ɓ��������߂̃��\�b�h���Ăяo��

        if (up) goup();//�O�ɓ��������߂̃��\�b�h���Ăяo��

        if (down) godown();//��ɓ��������߂̃��\�b�h���Ăяo��

        if (high) gohigh();//��ɓ��������߂̃��\�b�h���Ăяo��

        if (low) golow();//���ɓ��������߂̃��\�b�h���Ăяo��
        
        if (rt) gort();//���ɓ��������߂̃��\�b�h���Ăяo��

        if (lt) golt();//���ɓ��������߂̃��\�b�h���Ăяo��

        if (big) gobig();//�g�傽�߂̃��\�b�h���Ăяo��

        if (sml) gosml();//�k�����߂̃��\�b�h���Ăяo��

    }

    public void rPushDown()
    {
        //      �E�{�^���������Ă����
        right = true;
    }

    public void rPushUp()
    {
        //      �E�{�^���������̂���߂���
        right = false;
    }

    public void uPushDown()
    {
        //      �E�{�^���������Ă����
        up = true;
    }

    public void uPushUp()
    {
        //      �E�{�^���������̂���߂���
        up = false;
    }

    public void lPushDown()
    {
        //      ���{�^���������Ă����
        left = true;
    }

    public void lPushUp()
    {
        //      ���{�^���������̂���߂���
        left = false;
    }

    public void dPushDown()
    {
        //      �E�{�^���������Ă����
        down = true;
    }

    public void dPushUp()
    {
        //      ���{�^���������̂���߂���7
        down = false;
    }

    public void hPushDown()
    {
        //      �E�{�^���������Ă����
        high = true;
    }

    public void hPushUp()
    {
        //      ���{�^���������̂���߂���
        high = false;
    }

    public void bigPushDown()
    {
        //      �E�{�^���������Ă����
        big = true;
    }

    public void bigPushUp()
    {
        //      ���{�^���������̂���߂���
        big = false;
    }

    public void smlPushDown()
    {
        //      �E�{�^���������Ă����
        sml = true;
    }

    public void smlPushUp()
    {
        //      ���{�^���������̂���߂���
        sml = false;
    }

    public void lowPushDown()
    {
        //      �E�{�^���������Ă����
        low = true;
    }

    public void lowPushUp()
    {
        //      ���{�^���������̂���߂���
        low = false;
    }

    public void rtPushDown()
    {
        //      �E�{�^���������Ă����
        rt = true;
    }

    public void rtPushUp()
    {
        //      ���{�^���������̂���߂���
        rt = false;
    }
    public void ltPushDown()
    {
        //      �E�{�^���������Ă����
        lt = true;
    }

    public void ltPushUp()
    {
        //      ���{�^���������̂���߂���
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
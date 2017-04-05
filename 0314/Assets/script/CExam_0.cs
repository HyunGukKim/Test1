using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 	struct vs class 

		C#에서는 struct와 class가 다음과 같이 서로 다르다. 

		1) struct는 값 형식이고, class는 참조 형식이다. 
		2) struct는 상속을 지원하지 않는다.( 다만, System.ValueType을 상속받기는 한다.)
 */



public struct SUnitInfo
{

    //이건 struct에서 안됨, 멤버변수 초기화.
    //public int mX = 0;
    public int mX;
    public int mY;

    //struct는 매개변수 없는 생성자를 가질 수 없다.
    //public SUnitInfo()
    //{
    //}

    public SUnitInfo(int tX, int tY)
    {
        this.mX = tX;
        this.mY = tY;
    }
}


public class CExam_0 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        SUnitInfo tInfo_0 = new SUnitInfo();
        SUnitInfo tInfo_1 = new SUnitInfo(1,1);

        Debug.Log("tInfo_0: " + tInfo_0.mX.ToString() + ", " + tInfo_0.mY.ToString());

        Debug.Log("tInfo_1: " + tInfo_1.mX.ToString() + ", " + tInfo_1.mY.ToString());

    }

    // Update is called once per frame
    void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
    C/C++의 함수포인터와 비슷
	delegate

		임의의 메서드를 호출하는 방법을 담은 객체이다. 
		( 콜하는 측과 콜받는 측의 결합을 끊을 수 있게 된다. )


		deleagte 변수에 메서드를 배정하는 연산은 실행시점에 일어난다. 

	다중캐스트대리자 multicast delegate

		여러 개의 메서드를 대상으로 할 수 있다. 

*/


public class CUnit
{
    public int mX = 0;
    public int mY = 0;
    
    public int Doit(int tA)
    {
        Debug.Log("CUnit.Doit" + tA.ToString());

        return 0;
    }
}



public class CExam_1 : MonoBehaviour {

    delegate int KhgCallFunc(int tA);
    delegate void KhgCallExamMultiCast();


	// Use this for initialization
	void Start () {

        Debug.Log("@------------------------");

        int tResult = 0;

        Debug.Log(tResult);

        KhgCallFunc tKhgCallFunc = DoSquare;

        tResult = tKhgCallFunc(4);
        Debug.Log(tResult);

        //한번에 여러개를 호출할수도있따.
        KhgCallExamMultiCast tCall = null;
        tCall += InputControl;
        tCall += DisplayToConsole;
        tCall += SaveToFile;

        tCall();

        //인스턴스의 메서드를 대상으로 지정하는 경우 인스턴스도 표기해줘야 한다. 

        CUnit tUnit = new CUnit();
        KhgCallFunc tunitCallFunc = tUnit.Doit;

        tunitCallFunc(777);
    }

    // Update is called once per frame
    void Update () {
		
	}


    int DoSquare(int tA)
    {
        int tResult = 0;

        tResult = tA * tA;

        return tResult;
    }

    void InputControl()
    {
        Debug.Log("InputControl");
    }
    void DisplayToConsole()
    {
        Debug.Log("DisplayToConsole");
    }
    void SaveToFile()
    {
        Debug.Log("SaveToFile");
    }

}

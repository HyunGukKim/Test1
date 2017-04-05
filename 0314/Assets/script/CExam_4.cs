using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CExam_4 : MonoBehaviour {

	// Use this for initialization
	void Start () {
       //조건부컴파일
        #if UNITY_EDITOR
                Debug.Log("Unity Editor");
        #endif

        #if UNITY_ANDROID
            Debug.Log("Android");
        #endif

        #if UNITY_STANDALONE_OSX
            Debug.Log("Stand Alone OSX");
        #endif

        #if UNITY_STANDALONE_WIN
                Debug.Log("Stand Alone Windows");
        #endif
    }

    // Update is called once per frame
    void Update () {
		
	}

    //영역표기
    #region EXAM_AREA

    #endregion
}

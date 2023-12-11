using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class exittomain : MonoBehaviour
{
    public InputActionReference exittomainAction;
    private exitUI exitUIScript;
    public bool val = false;
    //public float updateInterval = 0.2f; // 시간 간격 설정 (초 단위)

    //private float timeSinceLastUpdate = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        exittomainAction.action.Enable();
        exitUIScript = FindObjectOfType<exitUI>();
    }

    // Update is called once per frame
    void Update()
    {


        // brakeAction의 현재 값을 읽어옴
        float exitValue = exittomainAction.action.ReadValue<float>();

        // brakeValue가 1이면 (버튼이 눌렸으면) val을 true로 설정
        val = (exitValue == 1);

        // 버튼이 눌렸을 때 로그를 출력
        if (val && exitUIScript.uiActive)
        {
            //Debug.Log("exit activated");
            SceneManager.LoadScene("Main_Menu");
        }


    }
}

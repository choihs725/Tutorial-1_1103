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
    //public float updateInterval = 0.2f; // �ð� ���� ���� (�� ����)

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


        // brakeAction�� ���� ���� �о��
        float exitValue = exittomainAction.action.ReadValue<float>();

        // brakeValue�� 1�̸� (��ư�� ��������) val�� true�� ����
        val = (exitValue == 1);

        // ��ư�� ������ �� �α׸� ���
        if (val && exitUIScript.uiActive)
        {
            //Debug.Log("exit activated");
            SceneManager.LoadScene("Main_Menu");
        }


    }
}

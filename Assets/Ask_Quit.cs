using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Content.Interaction;
using UnityEngine.XR.Interaction.Toolkit;

/*
public class Ask_Quit : MonoBehaviour
{
    public XRController controller; // XR Controller를 할당하기 위한 public 변수

    public GameObject uiPanel; // 활성화할 UI 패널

    private bool isMenuButtonPressed = false;

    // Start is called before the first frame update
    private void Start()
    {
        if (controller == null)
        {
            // 컨트롤러가 할당되지 않았다면 기본 메인 카메라에서 XR Controller를 찾아 할당
            controller = FindObjectOfType<XRController>();
        }

        if (uiPanel != null)
        {
            // UI 패널을 비활성화
            uiPanel.SetActive(false);
        }
        else
        {
            Debug.LogError("UI 패널이 할당되지 않았습니다!");
        }
    }

    // Update is called once per frame
    private void Update()
    {
        // 컨트롤러의 메뉴 버튼 상태를 직접 확인
        if (controller != null)
        {

            controller.inputDevice.TryGetFeatureValue(CommonUsages.secondaryButton, out bool leftBButton);
            // Oculus Quest 2의 메뉴 버튼은 PrimaryButton에 해당
            InputFeatureUsage<bool> primaryButtonUsage = CommonUsages.primaryButton;

            // 메뉴 버튼이 눌렸을 때
            if (leftBButton) //controller.inputDevice.TryGetFeatureValue(primaryButtonUsage, out isMenuButtonPressed) && isMenuButtonPressed
            {
                // UI 패널을 활성화 또는 비활성화
                ToggleUI();
            }
        }

    }

    private void ToggleUI()
    {
        // UI 패널의 활성화 여부를 토글
        uiPanel.SetActive(!uiPanel.activeSelf);
    }
}
*/
/*
public class Ask_Quit : MonoBehaviour
{
    public XRController controller; // XR Controller를 할당하기 위한 public 변수
    public GameObject uiPanel; // 활성화할 UI 패널

    private bool isMenuButtonPressed = false;

    // Start is called before the first frame update
    private void Start()
    {
        if (controller == null)
        {
            // 컨트롤러가 할당되지 않았다면 기본 메인 카메라에서 XR Controller를 찾아 할당
            controller = FindObjectOfType<XRController>();
        }

        if (uiPanel != null)
        {
            // UI 패널을 비활성화
            uiPanel.SetActive(false);
        }
        else
        {
            Debug.LogError("UI 패널이 할당되지 않았습니다!");
        }
    }

    // Update is called once per frame
    private void Update()
    {
        // 컨트롤러의 메뉴 버튼 상태를 직접 확인
        if (controller != null)
        {
            controller.inputDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool leftBButton);

            // Oculus Quest 2의 왼쪽 B 버튼은 PrimaryButton에 해당
            // CommonUsages.primaryButton으로 수정
            InputFeatureUsage<bool> primaryButtonUsage = CommonUsages.primaryButton;

            // 왼쪽 B 버튼이 눌렸을 때
            if (leftBButton)
            {
                // UI 패널을 활성화
                ToggleUI();
            }
        }
    }

    private void ToggleUI()
    {
        // UI 패널의 활성화 여부를 토글
        uiPanel.SetActive(!uiPanel.activeSelf);
    }
}
*/
using UnityEngine.InputSystem;

public class Ask_Quit : MonoBehaviour
{
    public InputActionReference exitAction;
    public bool val = false;
    public GameObject uiPanel; // 활성화할 UI 패널

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        exitAction.action.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        // brakeAction의 현재 값을 읽어옴
        float exitValue = exitAction.action.ReadValue<float>();

        // brakeValue가 1이면 (버튼이 눌렸으면) val을 true로 설정
        val = exitValue == 1;

        // 버튼이 눌렸을 때 로그를 출력
        if (val)
        {
            Debug.Log("Left Brake activated");
            uiPanel.SetActive(val);
        }
    }
}
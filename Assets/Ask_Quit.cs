using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Content.Interaction;
using UnityEngine.XR.Interaction.Toolkit;

/*
public class Ask_Quit : MonoBehaviour
{
    public XRController controller; // XR Controller�� �Ҵ��ϱ� ���� public ����

    public GameObject uiPanel; // Ȱ��ȭ�� UI �г�

    private bool isMenuButtonPressed = false;

    // Start is called before the first frame update
    private void Start()
    {
        if (controller == null)
        {
            // ��Ʈ�ѷ��� �Ҵ���� �ʾҴٸ� �⺻ ���� ī�޶󿡼� XR Controller�� ã�� �Ҵ�
            controller = FindObjectOfType<XRController>();
        }

        if (uiPanel != null)
        {
            // UI �г��� ��Ȱ��ȭ
            uiPanel.SetActive(false);
        }
        else
        {
            Debug.LogError("UI �г��� �Ҵ���� �ʾҽ��ϴ�!");
        }
    }

    // Update is called once per frame
    private void Update()
    {
        // ��Ʈ�ѷ��� �޴� ��ư ���¸� ���� Ȯ��
        if (controller != null)
        {

            controller.inputDevice.TryGetFeatureValue(CommonUsages.secondaryButton, out bool leftBButton);
            // Oculus Quest 2�� �޴� ��ư�� PrimaryButton�� �ش�
            InputFeatureUsage<bool> primaryButtonUsage = CommonUsages.primaryButton;

            // �޴� ��ư�� ������ ��
            if (leftBButton) //controller.inputDevice.TryGetFeatureValue(primaryButtonUsage, out isMenuButtonPressed) && isMenuButtonPressed
            {
                // UI �г��� Ȱ��ȭ �Ǵ� ��Ȱ��ȭ
                ToggleUI();
            }
        }

    }

    private void ToggleUI()
    {
        // UI �г��� Ȱ��ȭ ���θ� ���
        uiPanel.SetActive(!uiPanel.activeSelf);
    }
}
*/
/*
public class Ask_Quit : MonoBehaviour
{
    public XRController controller; // XR Controller�� �Ҵ��ϱ� ���� public ����
    public GameObject uiPanel; // Ȱ��ȭ�� UI �г�

    private bool isMenuButtonPressed = false;

    // Start is called before the first frame update
    private void Start()
    {
        if (controller == null)
        {
            // ��Ʈ�ѷ��� �Ҵ���� �ʾҴٸ� �⺻ ���� ī�޶󿡼� XR Controller�� ã�� �Ҵ�
            controller = FindObjectOfType<XRController>();
        }

        if (uiPanel != null)
        {
            // UI �г��� ��Ȱ��ȭ
            uiPanel.SetActive(false);
        }
        else
        {
            Debug.LogError("UI �г��� �Ҵ���� �ʾҽ��ϴ�!");
        }
    }

    // Update is called once per frame
    private void Update()
    {
        // ��Ʈ�ѷ��� �޴� ��ư ���¸� ���� Ȯ��
        if (controller != null)
        {
            controller.inputDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool leftBButton);

            // Oculus Quest 2�� ���� B ��ư�� PrimaryButton�� �ش�
            // CommonUsages.primaryButton���� ����
            InputFeatureUsage<bool> primaryButtonUsage = CommonUsages.primaryButton;

            // ���� B ��ư�� ������ ��
            if (leftBButton)
            {
                // UI �г��� Ȱ��ȭ
                ToggleUI();
            }
        }
    }

    private void ToggleUI()
    {
        // UI �г��� Ȱ��ȭ ���θ� ���
        uiPanel.SetActive(!uiPanel.activeSelf);
    }
}
*/
using UnityEngine.InputSystem;

public class Ask_Quit : MonoBehaviour
{
    public InputActionReference exitAction;
    public bool val = false;
    public GameObject uiPanel; // Ȱ��ȭ�� UI �г�

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        exitAction.action.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        // brakeAction�� ���� ���� �о��
        float exitValue = exitAction.action.ReadValue<float>();

        // brakeValue�� 1�̸� (��ư�� ��������) val�� true�� ����
        val = exitValue == 1;

        // ��ư�� ������ �� �α׸� ���
        if (val)
        {
            Debug.Log("Exit activated");
            uiPanel.SetActive(val);
        }
    }
}
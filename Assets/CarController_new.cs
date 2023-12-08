using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Content.Interaction;
using UnityEngine.XR.Interaction.Toolkit;

public class CarController_new : MonoBehaviour
{
    public XRLever lever;
    public XRKnob knob;

    private XRController leftController;
    private XRController rightController;

    public float forwardSpeed;
    public float turnSpeed;
    public float acceleration;
    public float brakeForce; // 추가: 브레이크 힘

    private float currentSpeed = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        // XR Toolkit을 통해 왼쪽과 오른쪽 컨트롤러 가져오기
        InputDevices.GetDevicesAtXRNode(XRNode.LeftHand, new List<InputDevice>());
        InputDevices.GetDevicesAtXRNode(XRNode.RightHand, new List<InputDevice>());
        leftController = FindObjectOfType<XRController>();
        rightController = FindObjectOfType<XRController>();
        Debug.Log("void Start finished");
    }

    // Update is called once per frame
    void Update()
    {
        float forwardVelocity = forwardSpeed + acceleration * Time.deltaTime;
        float turnInput = knob.value;
        float turnAngle = Mathf.Lerp(-1.0f,1.0f, turnInput) * turnSpeed * Time.deltaTime;
        
        turnAngle = Mathf.Clamp(turnAngle, -90.0f, 90.0f);

        // 새로운 회전을 적용
        transform.Rotate(Vector3.up, turnAngle);

        // Check if both A and X buttons are pressed
        if (CheckBrakeInput())
        {
            // Apply brake force
            currentSpeed -= brakeForce * Time.deltaTime;
        }

        // 가속도 적용
        //currentSpeed += acceleration * Time.deltaTime * (lever.value ? 0 : 1);

        //기어없는 가속도 적용
        currentSpeed += acceleration * Time.deltaTime;

        // 전진 이동
        transform.Translate(Vector3.forward * currentSpeed * Time.deltaTime);
        //Debug.Log("Moving Forward");   
        
        // 핸들 돌린 각도만큼 차량을 회전시킴
        float rotationAmount = turnInput * turnSpeed * Time.deltaTime;
        transform.Rotate(Vector3.up, rotationAmount);
    }
    bool CheckBrakeInput()
    {
        bool val = false;
        if (leftController && rightController)
        {
            leftController.inputDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool leftAButton);
            rightController.inputDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool rightAButton);
            if (leftAButton && rightAButton)
            {
                Debug.Log("X and A Button Pressed");
                val = true;
            }
        }
        else
        {
            val = false;
        }
        return val;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class exitUI : MonoBehaviour
{
    // Start is called before the first frame update
    private exit exitScript;
    public GameObject worldSpaceCanvas;
    private bool buttonPreviouslyPressed = false;
    public bool uiActive = false;

    public float updateInterval = 0.2f; // 시간 간격 설정 (초 단위)

    private float timeSinceLastUpdate = 0.0f;


    void Start()
    {
        exitScript = FindObjectOfType<exit>();
        worldSpaceCanvas.SetActive(uiActive);
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastUpdate += Time.deltaTime;

        if (timeSinceLastUpdate >= updateInterval)
        {
            bool buttonPressed = exitScript.val;

            if (buttonPressed)
            {
                if (buttonPressed != buttonPreviouslyPressed)
                {
                    uiActive = true;
                    worldSpaceCanvas.SetActive(uiActive);
                    buttonPreviouslyPressed = true;
                    if (uiActive)
                    {
                        Debug.Log("activating UI");
                    }
                    else
                    {
                        Debug.Log("deactivating UI");
                    }
                }
                else
                {
                    uiActive = false;
                    worldSpaceCanvas.SetActive(uiActive);
                    buttonPreviouslyPressed = false;
                }

                //Debug.Log("activating ui");

            }
            // 시간 간격 초기화
            timeSinceLastUpdate = 0.0f;
        }


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonNoScript : MonoBehaviour
{
    public GameObject uiPanel; // 연결된 UI 패널

    public void UIOff()
    {
        uiPanel.SetActive(false);
    }
    void Update()
    {

    }
    // Start is called before the first frame update
    /*
    private void Start()
    {
        // Button 컴포넌트에 대한 리스너 추가
        Button button = GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(OnClick);
        }
        else
        {
            Debug.LogError("Button 컴포넌트를 찾을 수 없습니다!");
        }
    }

    // Update is called once per frame
    
    private void OnClick()
    {
        // 연결된 UI 패널을 비활성화
        if (uiPanel != null)
        {
            uiPanel.SetActive(false);
        }
        else
        {
            Debug.LogError("UI 패널이 할당되지 않았습니다!");
        }
    }
    */
}

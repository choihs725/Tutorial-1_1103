using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    public TextMeshProUGUI Text;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("FirstText", 2f);




        // 매소드 이름 작성 "", 시간 지연 f
    }

    public void FirstText()
    {
        Text.text = "안녕하세요";

        Invoke("SecondText", 3f);
    }

    public void SecondText()
    {
        Text.text = "지금부터 급발진 대응 교육을 시작하겠습니다";

        Invoke("ThirdText", 4f);
    }
    public void ThirdText()
    {
        Text.text = "먼저 컨트롤러를 잡아주시기 바랍니다";

        Invoke("FourthText", 5f);
    }
    public void FourthText()
    {
        Text.text = "급발진 대응은 3단계로 이루어집니다";
        Invoke("FourthText_1", 4f); // 3초 뒤에 HideText 메서드 호출
    }
    public void FourthText_1()
    {
        Text.text = "첫 번째 단계는 '브레이크 밟기' 입니다";
        Invoke("FourthText_2", 5f); // 3초 뒤에 HideText 메서드 호출
    }
    public void FourthText_2()
    {
        Text.text = "왼쪽 컨트롤러의 X버튼과 ";
        Invoke("FourthText_3", 4f); // 3초 뒤에 HideText 메서드 호출
    }
    public void FourthText_3()
    {
        Text.text = "오른쪽 컨트롤러의 A버튼이 브레이크 입니다";
        Invoke("FourthText_4", 4f); // 3초 뒤에 HideText 메서드 호출
    }
    public void FourthText_4()
    {
        Text.text = "브레이크를 눌러주시기 바랍니다";
        Invoke("FourthText_5", 10f); // 3초 뒤에 HideText 메서드 호출

    }
    public void FourthText_5()
    {
        Text.text = "잘하셨습니다";
        Invoke("FourthText_6", 3f); // 3초 뒤에 HideText 메서드 호출
    }
    public void FourthText_6()
    {
        Text.text = "두 번째 단계는 '기어 변경' 입니다";
        Invoke("FourthText_7", 4f); // 3초 뒤에 HideText 메서드 호출
    }
    public void FourthText_7()
    {
        Text.text = "우측을 보시면 두 개의 손잡이가 있습니다";
        Invoke("FourthText_7_2", 7f); // 3초 뒤에 HideText 메서드 호출
    }
    public void FourthText_7_2()
    {
        Text.text = "순서대로 사이드 브레이크와 기어 입니다";
        Invoke("FourthText_8", 7f); // 3초 뒤에 HideText 메서드 호출
    }
    public void FourthText_8()
    {
        Text.text = "기어를 중립으로 변경해주시기 바랍니다";
        Invoke("FourthText_9", 10f); // 3초 뒤에 HideText 메서드 호출
    }
    public void FourthText_9()
    {
        Text.text = "잘하셨습니다";
        Invoke("FourthText_10", 3f); // 3초 뒤에 HideText 메서드 호출
    }
    public void FourthText_10()
    {
        Text.text = "마지막 단계는 '사이드브레이크 잠그기' 입니다";
        Invoke("FourthText_11", 5f); // 3초 뒤에 HideText 메서드 호출
    }
    public void FourthText_11()
    {
        Text.text = "바로 우측에 있는 사이드 브레이크를 잠가 주십시오";
        Invoke("FourthText_12", 10f); // 3초 뒤에 HideText 메서드 호출
    }
    public void FourthText_12()
    {
        Text.text = "잘하셨습니다";
        Invoke("FourthText_13", 3f); // 3초 뒤에 HideText 메서드 호출
    }
    public void FourthText_13()
    {
        Text.text = "급발진 대응 교육을 마치도록 하겠습니다";
        Invoke("FourthText_14", 4f); // 3초 뒤에 HideText 메서드 호출
    }
    public void FourthText_14()
    {
        Text.text = "실제 연습 주행을 위해 메뉴로 돌아가 주시기 바랍니다";
        //Invoke("HideText", 3f); // 3초 뒤에 HideText 메서드 호출
    }
    
    public void HideText()
    {
        Text.text = ""; // 문구를 빈 문자열로 설정하여 화면에서 사라지게 함
    }

    // Update is called once per frame
    void Update()
    {

    }
}

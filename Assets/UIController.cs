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




        // �żҵ� �̸� �ۼ� "", �ð� ���� f
    }

    public void FirstText()
    {
        Text.text = "�ȳ��ϼ���";

        Invoke("SecondText", 3f);
    }

    public void SecondText()
    {
        Text.text = "���ݺ��� �޹��� ���� ������ �����ϰڽ��ϴ�";

        Invoke("ThirdText", 4f);
    }
    public void ThirdText()
    {
        Text.text = "���� ��Ʈ�ѷ��� ����ֽñ� �ٶ��ϴ�";

        Invoke("FourthText", 5f);
    }
    public void FourthText()
    {
        Text.text = "�޹��� ������ 3�ܰ�� �̷�����ϴ�";
        Invoke("FourthText_1", 4f); // 3�� �ڿ� HideText �޼��� ȣ��
    }
    public void FourthText_1()
    {
        Text.text = "ù ��° �ܰ�� '�극��ũ ���' �Դϴ�";
        Invoke("FourthText_2", 5f); // 3�� �ڿ� HideText �޼��� ȣ��
    }
    public void FourthText_2()
    {
        Text.text = "���� ��Ʈ�ѷ��� X��ư�� ";
        Invoke("FourthText_3", 4f); // 3�� �ڿ� HideText �޼��� ȣ��
    }
    public void FourthText_3()
    {
        Text.text = "������ ��Ʈ�ѷ��� A��ư�� �극��ũ �Դϴ�";
        Invoke("FourthText_4", 4f); // 3�� �ڿ� HideText �޼��� ȣ��
    }
    public void FourthText_4()
    {
        Text.text = "�극��ũ�� �����ֽñ� �ٶ��ϴ�";
        Invoke("FourthText_5", 10f); // 3�� �ڿ� HideText �޼��� ȣ��

    }
    public void FourthText_5()
    {
        Text.text = "���ϼ̽��ϴ�";
        Invoke("FourthText_6", 3f); // 3�� �ڿ� HideText �޼��� ȣ��
    }
    public void FourthText_6()
    {
        Text.text = "�� ��° �ܰ�� '��� ����' �Դϴ�";
        Invoke("FourthText_7", 4f); // 3�� �ڿ� HideText �޼��� ȣ��
    }
    public void FourthText_7()
    {
        Text.text = "������ ���ø� �� ���� �����̰� �ֽ��ϴ�";
        Invoke("FourthText_7_2", 7f); // 3�� �ڿ� HideText �޼��� ȣ��
    }
    public void FourthText_7_2()
    {
        Text.text = "������� ���̵� �극��ũ�� ��� �Դϴ�";
        Invoke("FourthText_8", 7f); // 3�� �ڿ� HideText �޼��� ȣ��
    }
    public void FourthText_8()
    {
        Text.text = "�� �߸����� �������ֽñ� �ٶ��ϴ�";
        Invoke("FourthText_9", 10f); // 3�� �ڿ� HideText �޼��� ȣ��
    }
    public void FourthText_9()
    {
        Text.text = "���ϼ̽��ϴ�";
        Invoke("FourthText_10", 3f); // 3�� �ڿ� HideText �޼��� ȣ��
    }
    public void FourthText_10()
    {
        Text.text = "������ �ܰ�� '���̵�극��ũ ��ױ�' �Դϴ�";
        Invoke("FourthText_11", 5f); // 3�� �ڿ� HideText �޼��� ȣ��
    }
    public void FourthText_11()
    {
        Text.text = "�ٷ� ������ �ִ� ���̵� �극��ũ�� �ᰡ �ֽʽÿ�";
        Invoke("FourthText_12", 10f); // 3�� �ڿ� HideText �޼��� ȣ��
    }
    public void FourthText_12()
    {
        Text.text = "���ϼ̽��ϴ�";
        Invoke("FourthText_13", 3f); // 3�� �ڿ� HideText �޼��� ȣ��
    }
    public void FourthText_13()
    {
        Text.text = "�޹��� ���� ������ ��ġ���� �ϰڽ��ϴ�";
        Invoke("FourthText_14", 4f); // 3�� �ڿ� HideText �޼��� ȣ��
    }
    public void FourthText_14()
    {
        Text.text = "���� ���� ������ ���� �޴��� ���ư� �ֽñ� �ٶ��ϴ�";
        //Invoke("HideText", 3f); // 3�� �ڿ� HideText �޼��� ȣ��
    }
    
    public void HideText()
    {
        Text.text = ""; // ������ �� ���ڿ��� �����Ͽ� ȭ�鿡�� ������� ��
    }

    // Update is called once per frame
    void Update()
    {

    }
}

using UnityEngine;
using UnityEngine.SceneManagement; // �ʿ�

public class Scene : MonoBehaviour
{
    public GameObject ss;
    public GameObject qq;
    public GameObject ww;

    public void NextScene1()
    {
        SceneManager.LoadScene(1);
    }

    public void NextScene2()
    {
        // �� ��ȣ�� �̿��ؼ� �� �̵�
        SceneManager.LoadScene(2);  // 0 ��° �� �ε�
    }
    public void Button()
    {
        ss.SetActive(true);
        qq.SetActive(false);
        ww.SetActive(false);
    }
    public void Button1()
    {
        qq.SetActive(true);
        ss.SetActive(false);
        ww.SetActive(false);
    }
    public void Button2()
    {
        ww.SetActive(true);
        qq.SetActive(false);
        ss.SetActive(false);
    }
}
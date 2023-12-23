using UnityEngine;
using UnityEngine.SceneManagement; // 필요

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
        // 씬 번호를 이용해서 씬 이동
        SceneManager.LoadScene(2);  // 0 번째 씬 로드
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
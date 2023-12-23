using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopMove : MonoBehaviour
{
    public Text pauseText;
    void Update()
    {
        Debug.Log("Update");
        transform.Translate(Time.deltaTime, 0, 0);
    }
    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }

    public void OnTogglePauseButton()
    {
        if (Time.timeScale == 0) //����������
        {
            Time.timeScale = 1f; //����
            pauseText.text = "Pause";
        }
        else //�����̸�
        {
            Time.timeScale = 0; //���߱�
            pauseText.text = "Resume";
        }
    }
}

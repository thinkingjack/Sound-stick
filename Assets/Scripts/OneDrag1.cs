using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneDrag1 : MonoBehaviour
{
    private bool isDraggable = true;
    private bool dragging = false;
    private Vector3 offset;

    void OnMouseDown()
    {
        if (isDraggable && !dragging)
        {
            offset = gameObject.transform.position - GetMouseWorldPos();
            dragging = true;
        }
    }

    void OnMouseUp()
    {
        if (dragging)
        {
            dragging = false;
            isDraggable = false; // �巡�׸� ���� �Ŀ��� �ٽ� �巡������ ���ϵ��� ����
        }
    }

    void Update()
    {
        if (dragging)
        {
            Vector3 cursorPosition = GetMouseWorldPos() + offset;
            transform.position = cursorPosition;
        }
    }

    Vector3 GetMouseWorldPos()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = Camera.main.nearClipPlane;
        return Camera.main.ScreenToWorldPoint(mousePos);
    }
}
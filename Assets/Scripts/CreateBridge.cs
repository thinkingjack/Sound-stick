using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBridge : MonoBehaviour
{
    // ������ cube Prefab
    public Transform BridgeCreate;

    // ������ Prefab�� ������ ����
    public Transform bridge;

    // Prefab ���� �޼ҵ�
    public void DragBridge()
    {
        // ���� �����Ǿ� �巡�� ���� Prefab�� ���� ��� if�� �� �ڵ� ����
        if (bridge == null)
        {
            // ���� ȭ�鿡 �ִ� ���콺 Ŀ���� x,y,z ��ǥ
            Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);
            // ������Ʈ�� �̵��� �� ������ x,z ��ǥ�� ���� WorldPoint Vector3 position ����
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(position);
            bridge = Instantiate(BridgeCreate, new Vector3(worldPosition.x, 1f, worldPosition.y), Quaternion.identity);

            // �� ��ũ��Ʈ�� ������ Prefab�� �����ϰ� ����
            bridge.GetComponent<Drag>().createBridge = this;

            // �ش� ������Ʈ ��ũ��Ʈ�� draggable ������ true�� ������ ���콺�� ���� ������ �� �ְ� �����
            bridge.GetComponent<Drag>().draggable = true;

            
        }
    }
    public void OnSave()
    {
        SerializationManager.Save("bridgesave", SaveData.current);
    }
    public void OnLoad()
    {
        GameEvents.current.dispatchOnLoadEvent();
    }
}
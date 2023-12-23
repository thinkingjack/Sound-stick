using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBridge : MonoBehaviour
{
    // 생성할 cube Prefab
    public Transform BridgeCreate;

    // 생성한 Prefab을 저장할 변수
    public Transform bridge;

    // Prefab 생성 메소드
    public void DragBridge()
    {
        // 현재 생성되어 드래그 중인 Prefab이 없을 경우 if문 내 코드 실행
        if (bridge == null)
        {
            // 현재 화면에 있는 마우스 커서의 x,y,z 좌표
            Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);
            // 오브젝트를 이동할 때 움직일 x,z 좌표를 가진 WorldPoint Vector3 position 생성
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(position);
            bridge = Instantiate(BridgeCreate, new Vector3(worldPosition.x, 1f, worldPosition.y), Quaternion.identity);

            // 이 스크립트를 생성된 Prefab이 참조하게 변경
            bridge.GetComponent<Drag>().createBridge = this;

            // 해당 오브젝트 스크립트의 draggable 변수를 true로 변경해 마우스를 따라 움직일 수 있게 만든다
            bridge.GetComponent<Drag>().draggable = true;

            
        }
    }
    public void OnSave()
    {
        SerializationManager.Save("bridgesave", SaveData.current);
    }
    public void OnLoad()
    {
        //GameEvents.current.dispatchOnLoadEvent();
    }
}
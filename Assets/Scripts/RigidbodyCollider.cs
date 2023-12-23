using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyCollider : MonoBehaviour
{
    private Rigidbody[] allRigidbodies;
    private Collider[] allColliders;
    private bool physicsActivated = false;
    public GameObject dd;

    void Start()
    {
        // 모든 Rigidbody와 Collider를 가져오기
        allRigidbodies = FindObjectsOfType<Rigidbody>();
        allColliders = FindObjectsOfType<Collider>();

        // 처음에는 모든 Rigidbody와 Collider를 비활성화
        DisablePhysics();
    }

    public void DisablePhysics()
    {
        // Rigidbody 비활성화
        foreach (Rigidbody rb in allRigidbodies)
        {
            rb.isKinematic = true;
        }

        // Collider 비활성화
        //foreach (Collider collider in allColliders)
        //{
        //    collider.enabled = false;
        //}
    }

    public void EnablePhysics()
    {
        // Rigidbody 활성화
        foreach (Rigidbody rb in allRigidbodies)
        {
            rb.isKinematic = false;
        }

        // Collider 활성화
        foreach (Collider collider in allColliders)
        {
            collider.enabled = true;
        }
    }
    public void Move()
    {
        dd.transform.position = new Vector3(1.3f, -4.94f, 0);

        foreach (Rigidbody rb in allRigidbodies)
        {
            rb.isKinematic = true;
        }
    }
}
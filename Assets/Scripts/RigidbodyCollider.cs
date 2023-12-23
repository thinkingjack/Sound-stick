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
        // ��� Rigidbody�� Collider�� ��������
        allRigidbodies = FindObjectsOfType<Rigidbody>();
        allColliders = FindObjectsOfType<Collider>();

        // ó������ ��� Rigidbody�� Collider�� ��Ȱ��ȭ
        DisablePhysics();
    }

    public void DisablePhysics()
    {
        // Rigidbody ��Ȱ��ȭ
        foreach (Rigidbody rb in allRigidbodies)
        {
            rb.isKinematic = true;
        }

        // Collider ��Ȱ��ȭ
        //foreach (Collider collider in allColliders)
        //{
        //    collider.enabled = false;
        //}
    }

    public void EnablePhysics()
    {
        // Rigidbody Ȱ��ȭ
        foreach (Rigidbody rb in allRigidbodies)
        {
            rb.isKinematic = false;
        }

        // Collider Ȱ��ȭ
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
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collis : MonoBehaviour
{
    public GameObject dd;

    private void OnCollisionEnter(Collision other)
    {

        if (other.collider.gameObject.CompareTag("dd"))
        {
    
            Time.timeScale = 0f;

            dd.SetActive(true);
        }
    }
}
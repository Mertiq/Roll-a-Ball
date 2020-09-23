using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemasEt : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("dusman"))
        {
            Destroy(other.gameObject);
            SkorTut.SkorArttir();
        }
        if(other.CompareTag("delik"))
        {
            Destroy(gameObject);
        }

    }
}

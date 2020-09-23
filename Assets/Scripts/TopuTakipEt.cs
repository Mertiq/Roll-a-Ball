using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopuTakipEt : MonoBehaviour
{
    public GameObject top;
    Vector3 mesafe;

    void Start()
    {
        mesafe = transform.position - top.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = top.transform.position + mesafe;
    }

}

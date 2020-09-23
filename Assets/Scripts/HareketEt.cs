using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class HareketEt : MonoBehaviour
{
    private new Rigidbody rigidbody;
    float hiz = 5;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float yatay = Input.GetAxisRaw("Horizontal");
        float dikey = Input.GetAxisRaw("Vertical");

        Vector3 vector3 = new Vector3(yatay, 0, dikey);

        rigidbody.AddForce(vector3 * hiz);

    }
}

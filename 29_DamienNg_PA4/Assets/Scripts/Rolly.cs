using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rolly : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.forward * Time.deltaTime * 2000);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

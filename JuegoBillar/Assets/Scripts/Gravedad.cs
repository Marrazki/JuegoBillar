using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravedad : MonoBehaviour
{
    public Rigidbody rb;
    public float gravedad = -9.8f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce (new Vector3(0, 100 * gravedad * Time.deltaTime, 0));
    }
}

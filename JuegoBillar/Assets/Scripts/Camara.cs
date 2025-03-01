using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public GameObject taco;
    public GameObject bolaBlanca;
    float x;
    float z;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x = taco.transform.position.x;
        z = taco.transform.position.z;
        transform.position = new Vector3(x, 7f, z);
        this.gameObject.transform.LookAt(bolaBlanca.transform);
    }
}

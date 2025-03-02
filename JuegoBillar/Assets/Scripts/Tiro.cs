using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiro : MonoBehaviour
{
    public GameObject tiroPrefab;
    public GameObject tiroInicio;
    public Rigidbody tiroRigidbody;
    //public GameObject bolaBlanca;
    float fuerza = 2000;
    //float t;
    //float x;
    //float y;
    //float z;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("TIRO");
            GameObject tiroTemporal = Instantiate(tiroPrefab, tiroInicio.transform.position, tiroInicio.transform.rotation) as GameObject;
            Rigidbody rb = tiroTemporal.GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * fuerza);
            Destroy(tiroTemporal, 0.3f);
            Debug.Log("Tiro destruido");
        }
        

        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            x = Mathf.Lerp(transform.position.x, bolaBlanca.transform.position.x, t * fuerza);
            y = Mathf.Lerp(transform.position.y, bolaBlanca.transform.position.y, t * fuerza);
            z = Mathf.Lerp(transform.position.z, bolaBlanca.transform.position.z, t * fuerza);
            transform.position = new Vector3(x, y, z);
            t += Time.deltaTime /5;
        }*/
    }
    /*private void OnCollisionEnter(Collision collision)
    {
        Destroy(tiroRigidbody, 0.01f);
        Debug.Log("tiro destruido");
    }*/
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiro : MonoBehaviour
{
    public GameObject tiroPrefab;
    public GameObject tiroInicio;
    public Rigidbody tiroRigidbody;
    public GameObject bolaBlanca;
    public Vector3 prevPos;
    public Vector3 currVel;
    float fuerza = 2;
    public GameManager gameManager;
    void Start()
    {
        
    }
    /*IEnumerator CalcVelocity(Vector3 pos)
    {
        // Wait till it the end of the frame
        // Velocity = DeltaPosition / DeltaTime
        yield return new WaitForEndOfFrame();
        currVel = (pos - bolaBlanca.transform.position) / Time.deltaTime;
    }*/
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (fuerza < 3) 
            {
                fuerza = fuerza + 0.5f;
                Debug.Log("Fuerza: " + fuerza);
            }
        }
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (fuerza > 0.5)
            {
                fuerza = fuerza - 0.5f;
                Debug.Log("Fuerza: " + fuerza);
            }
        }
        //Si la bola blanca está quieta
        // Position at frame start
        /*prevPos = bolaBlanca.transform.position;
        StartCoroutine(CalcVelocity(prevPos));
        Debug.Log(currVel);
        if (currVel == Vector3.zero)
        {*/
        if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("TIRO");
                gameManager.tiros--;
                Debug.Log(gameManager.tiros);
                GameObject tiroTemporal = Instantiate(tiroPrefab, tiroInicio.transform.position, tiroInicio.transform.rotation) as GameObject;
                Rigidbody rb = tiroTemporal.GetComponent<Rigidbody>();
                rb.AddForce(transform.forward * 1000 * fuerza);
                Destroy(tiroTemporal, 0.3f);
                Debug.Log("Tiro destruido");
            }
        //}
    }
        if (gameManager.tiros < 0)
        {
            gameManager.Perder();
        }
}

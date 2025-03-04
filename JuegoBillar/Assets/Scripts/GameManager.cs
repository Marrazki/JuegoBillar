using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int tiros;
    // Start is called before the first frame update
    void Start()
    {
        tiros = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int GetTiros()
    { 
        return tiros;
    }
    void MeterBlanca()
    { 
        
    }
    void Perder()
    {
        if (tiros <= 0)
        {
            Debug.Log("Has perdido");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GanaPierde : MonoBehaviour
{
    public GameObject ganaste;
    public GameObject perdiste;

    public TimeIsCounting tiempo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (tiempo.pierde == true)
        {
            ganaste.SetActive(true);
            perdiste.SetActive(false);
        }

        if (tiempo.time <= 1)
        {
            ganaste.SetActive(true);
            perdiste.SetActive(false);
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GanaPierde : MonoBehaviour
{
    public GameObject ganaste;
    public GameObject perdiste;
    public perdisteData perder;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (perder.GANASTE == true)
        {
            ganaste.SetActive(true);
            perdiste.SetActive(false);

        }
        else
        {
            ganaste.SetActive(false);
            perdiste.SetActive(true);
        }
    }
}

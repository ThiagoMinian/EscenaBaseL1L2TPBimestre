using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GanaPierde : MonoBehaviour
{
    public GameObject ganaste;
    public GameObject perdiste;

    public TimeIsCounting Timexcvn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Timexcvn.pierde == true)
        {
            Debug.Log(Timexcvn.pierde);
            ganaste.SetActive(true);
            perdiste.SetActive(false);
        }
    }
}

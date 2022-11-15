using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GanaPierde : MonoBehaviour
{
    public GameObject ganaste;
    public GameObject perdiste;
    public perdisteData perder;
    private bool showCursor = false;
    // Start is called before the first frame update
    void Start()
    {
        showCursor = true;
        if (showCursor == true)
        {
            Cursor.visible = true;
        }
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

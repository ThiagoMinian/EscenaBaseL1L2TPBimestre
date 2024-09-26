using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showCursor : MonoBehaviour
{
    private bool mostrarcursor = true;
    
    // Start is called before the first frame update
    void Start()
    {
        if (mostrarcursor == true)
        {
            Cursor.visible = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

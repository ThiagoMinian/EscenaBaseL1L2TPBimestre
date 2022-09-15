using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioBoton : MonoBehaviour
{
    
    public void OnClick()
    {
        SceneManager.LoadScene("Tic L1 L2 controller");
    }
}

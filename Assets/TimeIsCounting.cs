using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeIsCounting : MonoBehaviour
{
    public float time = 30;
    public Text txtCountdown;
    public perdisteData pierde;
    // Start is called before the first frame update
    void Start()
    {
        pierde.GANASTE = false;
    }

    // Update is called once per frame
    void Update()
    {
        txtCountdown.text = Mathf.Floor(time).ToString();
        time -= Time.deltaTime;

        if (time <= 2)
        {
            pierde.GANASTE = true;

            if (time <= 1)
            {
                SceneManager.LoadScene(2);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeIsCounting : MonoBehaviour
{
    float time = 30;
    public Text txtCountdown;

    public bool pierde = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        txtCountdown.text = Mathf.Floor(time).ToString();
        time -= Time.deltaTime;

        if (time <= 1)
        {
            pierde = true;
            SceneManager.LoadScene(2);
        }
    }
}

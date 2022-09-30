using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarroNet : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject computerPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InstiantateComputer()
    {
        Instantiate(computerPrefab, spawnPoint.position, Quaternion.identity);
    }
}

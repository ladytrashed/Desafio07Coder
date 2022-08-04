using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject prefab;
    public float waitingTime = 2f;
    public float repetitionTime = 2f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", waitingTime, repetitionTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void SpawnObject()
    {
        Instantiate(prefab, transform);
    }
}

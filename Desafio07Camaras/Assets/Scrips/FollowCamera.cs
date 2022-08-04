using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //lateUpdate se ejecuta casi al final de cada frame
    private void lateUpdate()
    {
        transform.position = target.transform.position;
    }
}

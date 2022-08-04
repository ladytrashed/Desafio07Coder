using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentBack : MonoBehaviour
{
    public float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    private void Move()
    {
        transform.position += Vector3.back * speed * Time.deltaTime;
    }
}

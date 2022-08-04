using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moviment : MonoBehaviour
{
    public float speed = 2f;
    public float liveTime = 3f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyDelay", liveTime);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    private void Move()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    private void DestroyDelay()
    {
        Debug.Log("DESTROY DELAY");
        Destroy(gameObject);
    }
}

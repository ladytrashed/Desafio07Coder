using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 3f;
    public GameObject munition;
    public float cameraAxisX = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
        if (Input.GetKey(KeyCode.W))
        {
            MovePlayer(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.S))
        {
            MovePlayer(Vector3.back);
        }
        if (Input.GetKey(KeyCode.A))
        {
            MovePlayer(Vector3.left);
        }
        if (Input.GetKey(KeyCode.D))
        {
            MovePlayer(Vector3.right);
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            Shoot();
        }
    }
    private void MovePlayer(Vector3 direction)
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
    private void Shoot()
    {
        Debug.Log("DISPARAR");
        Instantiate(munition, transform.position, transform.rotation);
    }
    public void RotatePlayer()
    {
        cameraAxisX += Input.GetAxis("Mouse X");
        //transform.rotation = Quaternion.Euler(0, cameraAxisX * 0.5f, 0);
        Quaternion newRotation = Quaternion.Euler(0, cameraAxisX, 0);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, 2f * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    [Range(1f, 10f)]
    private float speed = 1f;

    /*[SerializeField]
    [Range(0, 1)]
    private int typeEnemy = 0;*/
    // Start is called before the first frame update
    enum CyborgTypes {Stalker, Rioter }
    [SerializeField] CyborgTypes cyborgType;
    [SerializeField] Transform playerTransform;

    private void Start()
    {
        
    }
    void Update()
    {
       /*if (tipeEnemy == 0)
        {
            Debug.Log(name + "-> SEGUIR AL JUGADOR");
        }
        if (tipeEnemy == 1)
        {
            Debug.Log(name + "-> ROTAR AL REDEDOR");
        }*/
        switch (cyborgType)
        {
            case CyborgTypes.Stalker:
                ChasePlayer();
                break;
            case CyborgTypes.Rioter:
                RotateAroundPlayer();
                break;

        }
    }

    // Update is called once per frame
    void RotateAroundPlayer()
    {
        LookPlayer();
        transform.RotateAround(playerTransform.position, Vector3.up, 5f * Time.deltaTime);
    }
    void ChasePlayer()
    {
        LookPlayer();
        Vector3 direction = (playerTransform.position - transform.position);
        if (direction.magnitude > 1f)
        {
            transform.position += direction.normalized * speed * Time.deltaTime;
        }

    }
        private void LookPlayer()
        {
            transform.LookAt(playerTransform);
        }
    
}

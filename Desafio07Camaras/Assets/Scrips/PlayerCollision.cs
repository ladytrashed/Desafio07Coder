using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private PlayerData PlayerData;
    private void Start()
    {
        PlayerData = GetComponent<PlayerData>();
    }
    private void OnCollisionEnter(Collision other)
    {
        //Debug.Log("ENTRANDO EN COLISION CON ->" + other.gameObject.name);
        if (other.gameObject.CompareTag("Powerups"))
        {
            Destroy(other.gameObject);
            PlayerData.live++;
        }
    }
    private void OnCollisionStay(Collision other)
    {
        //Debug.Log("EN CONTACTO CON ->" + other.gameObject.name);
    }
    private void OnCollisionExit(Collision other)
    {
        //Debug.Log("SALGO DE LA COLISION ->" + other.gameObject.name);
    }
    private void OnTriggerEnter(Collider other)
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        
    }
    private void OnTriggerExit(Collider other)
    {
        
    }
}

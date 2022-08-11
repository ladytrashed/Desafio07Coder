using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public int live = 1;
    public void healing(int value)
    {
        live += value;
    }
}

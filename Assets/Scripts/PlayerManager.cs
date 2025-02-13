using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance;
    public Player player;

    private void Awake()
    {
        // in the scene there should be only 1 instance otherwise we can crash so just checking that
        if (instance != null)
            Destroy(instance.gameObject);
        else
            instance = this;
    }
}

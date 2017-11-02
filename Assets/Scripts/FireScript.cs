using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScript : MonoBehaviour
{
    public GameObject Fire;
    public GameObject Coin;

    void Start()
    {
        if (Fire == null)
        {
            throw new MissingReferenceException("Missing Fire Object");
        }
        if (Coin == null)
        {
            throw new MissingReferenceException("Missing Coin Object");
        }
    }

    void SnowBalled()
    {
        if (PutOutFire()) { 
            SpawnCoin();
        }
    }

    bool PutOutFire()
    {
        bool retval = false;
        if (Fire != null)
        {
            DestroyObject(Fire);
            Fire = null;
            retval = true;
        }

        return retval;
    }

    void SpawnCoin()
    {
        GameObject coin = GameObject.Instantiate(Coin);
        coin.transform.position = transform.position + new Vector3(1f,0f,-1f);  // initial position
        coin.AddComponent<Popup>();
    }
}

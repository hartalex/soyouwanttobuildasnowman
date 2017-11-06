using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScript : MonoBehaviour
{
    public GameObject Fire;
    public GameObject Coin;

    public float duration;
    private float startTime;
    private bool empty = false;
    public int coinCount = 1;
    public int coinRadius = 5;
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

    void FixedUpdate()
    {
        if (!Fire.activeSelf && Time.time - startTime > duration)
        {
            Fire.SetActive(true);
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
        if (Fire.activeSelf)
        {
            Fire.SetActive(false);
            retval = true;
            startTime = Time.time;
        }

        return retval;
    }

    void SpawnCoin()
    {
        if (!empty)
        {
            for (int i = 0; i < coinCount; i++)
            {
                float radius = i * (365 / coinCount);
                Vector3 direction = new Vector3(Mathf.Sin(radius), 0, Mathf.Cos(radius)) * coinRadius;
                GameObject coin = GameObject.Instantiate(Coin);
                coin.transform.position = transform.position+ direction;  // initial position
                
                coin.AddComponent<Popup>();
            }
            empty = true;
        }
    }
}

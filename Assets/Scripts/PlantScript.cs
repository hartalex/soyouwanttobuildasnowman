using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantScript : MonoBehaviour
{
    public GameObject Coin;
    public Animator animator;

    private bool empty = false;
    public int coinCount = 1;
    public int coinRadius = 5;
    void Start()
    {
     
        if (Coin == null)
        {
            throw new MissingReferenceException("Missing Coin Object");
        }
        if (animator == null)
        {
            animator = GetComponent<Animator>();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Body>() != null)
        {
            SnowBalled();
        }
    }

    void SnowBalled()
    {
        SpawnCoin();
        Animate();    
    }
    
    void Animate()
    {
        animator.SetTrigger("Wave");
    }

    void SpawnCoin()
    {
        if (!empty)
        {
            
                for (int i = 0; i < coinCount; i++)
                {
                    float radius = i * (365 / coinCount);
                    Vector3 direction = Vector3.up;
                    if (coinCount > 1)
                    {
                        direction = new Vector3(Mathf.Sin(radius), 0, Mathf.Cos(radius)) * coinRadius;
                    }
                    GameObject coin = GameObject.Instantiate(Coin);
                    coin.transform.position = transform.position + direction;  // initial position

                    coin.AddComponent<Popup>();
                }
           
            empty = true;
        }
    }
}

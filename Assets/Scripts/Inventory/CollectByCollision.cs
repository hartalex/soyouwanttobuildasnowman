using UnityEngine;
using System.Collections;

public class CollectByCollision : MonoBehaviour
{
    public CollectionTypes collectionType;
    public int value;
    public GameObject particles;

    void OnTriggerEnter(Collider collider)
    {
        if (collectionType == CollectionTypes.Coins)
        {
            CoinPurse coinPurse = collider.gameObject.GetComponent<CoinPurse>();
            if (coinPurse != null)
            {   
                if (particles != null)
                {
                    GameObject initParticles = GameObject.Instantiate(particles);
                    initParticles.transform.position = transform.position;
                }
                coinPurse.AddCoins(value);
                DestroyObject(this.gameObject);
            }
        }
    }
}

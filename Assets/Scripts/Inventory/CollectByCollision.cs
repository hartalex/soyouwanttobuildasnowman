using UnityEngine;
using System.Collections;

public class CollectByCollision : MonoBehaviour
{
    public CollectionTypes collectionType;
    public int value;

    void OnTriggerEnter(Collider collider)
    {
        if (collectionType == CollectionTypes.Coins)
        {
            CoinPurse coinPurse = collider.gameObject.GetComponent<CoinPurse>();
            if (coinPurse != null)
            {
                coinPurse.AddCoins(value);
                DestroyObject(this.gameObject);
            }
        }
    }
}

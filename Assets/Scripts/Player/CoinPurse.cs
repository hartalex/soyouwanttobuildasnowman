using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinPurse : MonoBehaviour
{

    private int coinCount = 0;
    public Text uiCoinsText = null;

    public void AddCoins(int coins)
    {
        coinCount += coins;
        uiCoinsText.text = coinCount.ToString().PadLeft(4,'0');
    }

    public int GetCoins()
    {
        return coinCount;
    }
}

using UnityEngine;

public class CountCoinController : MonoBehaviour
{
    private static int _coins;

    private void Start()
    {
        _coins = 0;
    }

    public delegate void OnCoinTake(int totalCoins);
    public static event OnCoinTake onCoinTake;

    public static void OnPlayerCoinsChanged(int takeCoins)
    {
        _coins += takeCoins;
        onCoinTake(_coins);
    }
}

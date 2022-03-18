using UnityEngine;
using UnityEngine.UI;

public class CoinsText : MonoBehaviour
{
    [SerializeField]
    private Text _countText;

    void Start()
    {
        CountCoinController.onCoinTake += OnPlayerCoinsChangedText;
    }
    void OnDestroy()
    {
        CountCoinController.onCoinTake -= OnPlayerCoinsChangedText;
    }

    private void OnPlayerCoinsChangedText(int coins)
    {
        _countText.text = coins.ToString();
    }    
}

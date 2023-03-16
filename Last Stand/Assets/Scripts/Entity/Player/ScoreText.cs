using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    public int coinCount;

    public void IncrementCoin()
    {
        coinCount++;
        GetComponent<TextMeshProUGUI>().text = $"Coins: {coinCount}";
        Debug.Log("Evento enviado por CollectCoins, recibido por ScoreText");
    }
}

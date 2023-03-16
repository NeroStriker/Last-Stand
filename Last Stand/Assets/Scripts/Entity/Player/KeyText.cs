using TMPro;
using UnityEngine;

public class KeyText : MonoBehaviour
{
    public int keyCount;

    public void IncrementKey()
    {
        keyCount++;
        GetComponent<TextMeshProUGUI>().text = $"Key: {keyCount}";
        Debug.Log("Evento enviado por CollectKey, recibido por KeyText");
    }
    public void UseKey()
    {
        keyCount--;
    }
}

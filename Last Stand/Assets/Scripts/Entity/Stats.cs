using UnityEngine;

[CreateAssetMenu(fileName = "Stats", menuName = "ScriptableObjects/Stats")]
public class Stats : ScriptableObject
{
    public int maxHealth;
    public int currentHealth;
    public int damage;
}

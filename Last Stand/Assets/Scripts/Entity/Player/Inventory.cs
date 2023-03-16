using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Inventory : MonoBehaviour
{
    Dictionary<GameObject, int> inventory = new Dictionary<GameObject, int>();
    public GameObject healingSlime;
    public int healAmount;
    public TextMeshProUGUI inventoryDisplay;
    public GameObject emptySlime;
    


    private void Start()
    {
        inventory.Add(healingSlime, 4);
        TryToHeal();
        
        
    }
    private void Update()
    {
        Heal();
        DisplayInventory();
    }
    void Heal()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            TryToHeal();
        }
    }

    public void DisplayInventory()
    {
        inventoryDisplay.SetText("");
        foreach(var item in inventory)
        {
            inventoryDisplay.SetText(item.Value.ToString());
        }
    }

    void TryToHeal()
    {
        if(inventory.ContainsKey(healingSlime))
        {
            
            PlayerHealth l_playerHealth = GetComponent<PlayerHealth>();
            if (l_playerHealth != null)
            {
                l_playerHealth.Heal(healAmount);
                inventory[healingSlime]--;
            }
            if (inventory[healingSlime] <= 0)
            {
                inventory.Remove(healingSlime);
                emptySlime.SetActive(true);

            }
        }
        
    }
   
}

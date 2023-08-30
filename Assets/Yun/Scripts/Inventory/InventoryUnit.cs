using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUnit : MonoBehaviour
{
    private InventoryItem InventoryItem;

    [SerializeField]
    private Button useButton;

    [SerializeField]
    private TextMeshProUGUI textAmount;

    [SerializeField]
    private Image icon;

    public void AddItem(InventoryItem inventoryItem)
    {
        useButton.interactable = true;
        InventoryItem = inventoryItem;
        textAmount.text = inventoryItem.data.name;
        icon.sprite = inventoryItem.data.icon;
    }

    public void UseItem()
    {
        InventoryItem.Use();
    }

    public void RemoveItem()
    {
        useButton.interactable = false;
        textAmount.text = "";
    }

 
}

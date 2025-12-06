using System.Collections.Generic;
using Assets.WUG.Scripts;
using TMPro;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public Dictionary<string, Sprite> HeldItems;
    public GameObject UserInterface;
    private InventoryUIController InventoryUIController;

    void Start()
    {
        HeldItems = new Dictionary<string, Sprite>();
        InventoryUIController = UserInterface.GetComponent<InventoryUIController>();
    }

    public void Add(string name, Sprite sprite, int value)
    {
        HeldItems.Add(name, sprite);
    }

    public bool IsHolding(string name) 
    {
        if (HeldItems.ContainsKey(name)) {
            return true;
        }
        else {
            return false;
        }
    }

}

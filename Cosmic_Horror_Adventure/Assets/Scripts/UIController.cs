using UnityEngine;
using UnityEngine.InputSystem;

public class UIController : MonoBehaviour
{
    public GameObject InventoryBackground;
    public GameObject InventoryItems;
    
    GameObject PlayerObj;
    bool Active;
    PlayerInventory playerInventory;

    void Start()
    {
        PlayerObj = gameObject;
        playerInventory = PlayerObj.GetComponent<PlayerInventory>();
    }

    void ToggleInventory()
    {
        if (Active) {
            InventoryBackground.SetActive(true);
            InventoryItems.SetActive(true);

        }
        if (!Active) {
            InventoryBackground.SetActive(false);
            InventoryItems.SetActive(false);
        }
    }

    void DisplayItems()
    {
        
    }


}
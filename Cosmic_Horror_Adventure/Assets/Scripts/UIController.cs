using UnityEngine;
using UnityEngine.InputSystem;


public class UIController : MonoBehaviour
{
    public GameObject DarkOverlay;
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

    public void ToggleInventory()
    {
        // if already on, turn it off
        if (Active) {
            Active = false;
            DarkOverlay.SetActive(false);
            InventoryBackground.SetActive(false);
            InventoryItems.SetActive(false);
            Time.timeScale = 1;
        }
        //if already off, turn it on
        else {
            Active = true;
            DarkOverlay.SetActive(true);
            InventoryBackground.SetActive(true);
            InventoryItems.SetActive(true);
            Time.timeScale = 0;
        }
    }

    void UpdateInventoryItems()
    {
        
    }


}
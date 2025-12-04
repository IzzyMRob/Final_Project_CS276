using UnityEngine;
using System.Collections;

public class Door : Interactable
{

    public GameObject Connection;
    public string Required;
    private PlayerInventory Inventory;
    private GameObject NoMessage;

    public override void GetSpecificValues()
    {
        NoMessage = gameObject.transform.GetChild(1).gameObject;
    }

    public override void Use()
    {
        Inventory = PlayerObj.GetComponent<PlayerInventory>();
        // either we dont need anything, or we have what we need already
        if (Required == "" | Inventory.IsHolding(Required)) {
            Vector3 con_pos = Connection.transform.position;
            PlayerObj.transform.position = con_pos;
            PlayerObj.GetComponent<PlayerController>().SetCurrentInteractable(Connection);
        // we need something and we dont have it
        } else {
            StartCoroutine(ShowNoMessage());
        }
    }

    public override void ProximityTurnOff()
    {
        NoMessage.SetActive(false);
    }

    IEnumerator ShowNoMessage()
    {
        NoMessage.SetActive(true);
        yield return new WaitForSeconds(5); // Wait for 3 seconds
        NoMessage.SetActive(false);
    }



}

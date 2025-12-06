using UnityEngine;
using UnityEngine.Rendering;

public class Pickup : Interactable
{
    public string Name;
    public Sprite sprite;
    public int value;

    public override void Use()
    {
        // remove object from world, add to player inventory
        Debug.Log(value);
        PlayerObj.GetComponent<PlayerInventory>().Add(Name, sprite, value);
        Destroy(gameObject);
    }

    public override void GetSpecificValues() {}
    public override void ProximityTurnOff() {}
}

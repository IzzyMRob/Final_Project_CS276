using UnityEngine;
using UnityEngine.Rendering;

public class Pickup : Interactable
{
    public string Name;
    public Sprite sprite;

    public override void Use()
    {
        // remove object from world, add to player inventory
        PlayerObj.GetComponent<PlayerInventory>().Add(Name, sprite);
        Destroy(gameObject);
    }

    public override void GetSpecificValues() {}
}

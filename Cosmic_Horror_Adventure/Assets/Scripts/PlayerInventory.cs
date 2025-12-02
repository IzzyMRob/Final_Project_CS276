using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    Dictionary<string, Sprite> HeldItems;

    void Start()
    {
        HeldItems = new Dictionary<string, Sprite>();
    }

    public void Add(string name, Sprite sprite)
    {
        Debug.Log(name);
        Debug.Log(sprite);
        HeldItems.Add(name, sprite);
    }

    public void Remove(string name, Sprite sprite)
    {
        HeldItems.Remove(name);
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

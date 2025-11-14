using UnityEngine;

public class Door : Interactable
{

    public GameObject Connection;

    public override void Use()
    {
        Debug.Log("Used Door");
        Vector3 con_pos = Connection.transform.position;
        PlayerObj.transform.position = con_pos;
    }
}

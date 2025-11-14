using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Public Variables
    public float MoveSpeed = 5f;
    public GameObject CurrentInteractable;

    // private variables
    Vector2 MoveVal;
    UIController uiController;

    void FixedUpdate()
    {
        transform.Translate(MoveVal * MoveSpeed * Time.deltaTime);
    }

    void OnMove(InputValue input)
    {
        MoveVal = input.Get<Vector2>();
    }

    void OnInteract()
    {
        Debug.Log("Interacted");
        CurrentInteractable.GetComponent<Interactable>().Use();
    }

    void OnInventory() 
    {

    }



}

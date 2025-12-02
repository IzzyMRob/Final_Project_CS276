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
    private Animator animator;
    private SpriteRenderer spriteRenderer;

    void Start() {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        uiController = GetComponent<UIController>();
    }

    void FixedUpdate()
    {
        transform.Translate(MoveVal * MoveSpeed * Time.deltaTime);
        
        if (MoveVal[0] == 0 && MoveVal[1] == 0) { // no input
            animator.Play("Idle");
        } 
        else if (MoveVal[1] < 0) { // down in y
            animator.Play("WalkDown");
        }
        else if (MoveVal[1] > 0) { // up in y
            animator.Play("WalkUp");
        }
        else if (MoveVal[0] < 0) { // left in x
            gameObject.transform.localScale = new Vector3(-1, 1, 1);
            animator.Play("WalkSide");
        } 
        else if (MoveVal[0] > 0) { // right in x
            gameObject.transform.localScale = new Vector3(1, 1, 1);
            animator.Play("WalkSide");
        }
    }

    void OnMove(InputValue input)
    {
        MoveVal = input.Get<Vector2>();
    }

    void OnInteract()
    {
        CurrentInteractable.GetComponent<Interactable>().Use();
    }

    public void SetCurrentInteractable(GameObject NewInteractable)
    {
        CurrentInteractable = NewInteractable;
    }

    void OnInventory() 
    {
        Debug.Log("Inventory called");
        uiController.ToggleInventory();
    }



}

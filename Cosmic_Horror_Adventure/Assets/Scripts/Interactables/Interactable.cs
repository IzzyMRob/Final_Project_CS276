using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    public GameObject ParentObj;
    GameObject PopUp;
    public GameObject PlayerObj;

    void Start()
    {
        // grab pop-up object
        ParentObj = gameObject;
        PopUp = ParentObj.transform.GetChild(0).gameObject;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        // turn on interaction pop-up
        if (collider.gameObject.tag == "Player")
        {
            PopUp.SetActive(true);
            PlayerObj = collider.gameObject;
            PlayerObj.GetComponent<PlayerController>().CurrentInteractable = ParentObj;
        }

    }

    void OnTriggerExit2D(Collider2D collider)
    {
        // turn off interaction pop-up
        if (collider.gameObject.tag == "Player")
        {
            PopUp.SetActive(false);
            PlayerObj.GetComponent<PlayerController>().CurrentInteractable = null;
        }

    }

    public abstract void Use();

}

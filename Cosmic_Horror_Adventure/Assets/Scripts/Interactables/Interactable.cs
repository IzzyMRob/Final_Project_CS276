using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    GameObject PopUp;
    public GameObject PlayerObj;

    void Start()
    {
        // grab pop-up object
        PopUp = gameObject.transform.GetChild(0).gameObject;
        PlayerObj = null;
        GetSpecificValues();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        // turn on interaction pop-up, set player's current interactable to this one
        if (collider.gameObject.tag == "Player")
        {
            PopUp.SetActive(true);
            PlayerObj = collider.gameObject;
            PlayerObj.GetComponent<PlayerController>().SetCurrentInteractable(gameObject);
        }

    }

    void OnTriggerExit2D(Collider2D collider)
    {
        // turn off interaction pop-up, set player's current interactable to none
        if (collider.gameObject.tag == "Player")
        {
            PopUp.SetActive(false);
            PlayerObj.GetComponent<PlayerController>().CurrentInteractable = null;
        }

    }

    public abstract void Use();
    public abstract void GetSpecificValues();

}

using UnityEngine;
using System.Collections;

public class StoryPopUp : Interactable
{
        private GameObject Textbox;

    public override void GetSpecificValues()
    {
        Textbox = gameObject.transform.GetChild(1).gameObject;
    }

    public override void Use()
    {
        StartCoroutine(ShowTextbox());
    }

    public override void ProximityTurnOff()
    {
        Textbox.SetActive(false);
    }

    IEnumerator ShowTextbox()
    {
        Textbox.SetActive(true);
        yield return new WaitForSeconds(7); // Wait for 3 seconds
        Textbox.SetActive(false);
    }

}
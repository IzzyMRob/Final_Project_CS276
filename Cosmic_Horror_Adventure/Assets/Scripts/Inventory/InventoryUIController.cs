using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UnityEngine.UIElements;
using UnityEngine;

namespace Assets.WUG.Scripts
{
    public class InventoryUIController : MonoBehaviour
    {
        public List<InventorySlot> InventoryItems = new List<InventorySlot>();
        public GameObject PlayerObj;
        private VisualElement m_Root;
        private VisualElement m_SlotContainer;
        private int numSlots = 24;

        public void Awake()
        {
            //Store the root from the UI Document component
            m_Root = GetComponent<UIDocument>().rootVisualElement;
            Debug.Log("Awake called");

            //Search the root for the SlotContainer Visual Element
            m_SlotContainer = m_Root.Q<VisualElement>("SlotContainer");

            //Create 20 InventorySlots and add them as children to the SlotContainer
            for (int i = 0; i < numSlots; i++)
            {
                InventorySlot item = new InventorySlot();
                InventoryItems.Add(item);
                m_SlotContainer.Add(item);
            }

            PopulateInventory();
        }        

        public void PopulateInventory()
        {
            Debug.Log(PlayerObj.GetComponent<PlayerInventory>().HeldItems.Count);
            foreach (var (name, sprite) in PlayerObj.GetComponent<PlayerInventory>().HeldItems)
            {
                var emptySlot = InventoryItems.FirstOrDefault(x => x.ItemGuid.Equals(""));
                if (emptySlot != null) {
                    Debug.Log(emptySlot);
                    emptySlot.HoldItem(name, sprite);
                }
            }
        }
    }
}
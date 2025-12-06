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
        private bool slotsCreated = false;

        public void Awake()
        {
            CreateSlots();
        }

        private void OnEnable()
        {
            // Re-setup the UI elements when Canvas is enabled
            PopulateInventory();
            SetupUIElements();
        }

        private void CreateSlots()
        {
            if (slotsCreated)
                return;

            // Create InventorySlots
            for (int i = 0; i < numSlots; i++)
            {
                InventorySlot item = new InventorySlot();
                InventoryItems.Add(item);
            }

            slotsCreated = true;
        }

        private void SetupUIElements()
        {
            // Store the root from the UI Document component
            m_Root = GetComponent<UIDocument>().rootVisualElement;

            // Search the root for the SlotContainer Visual Element
            m_SlotContainer = m_Root.Q<VisualElement>("SlotContainer");

            // Clear the container first
            m_SlotContainer.Clear();

            // Add all inventory slots to the container
            foreach (var slot in InventoryItems)
            {
                if (slot.ItemGuid != "") {
                    m_SlotContainer.Add(slot);
                }
            }

        }       

        public void PopulateInventory()
        {
            // Make sure slots are created
            if (!slotsCreated)
            {
                CreateSlots();
            }

            // Clear all slots first when repopulating
            foreach (var slot in InventoryItems)
            {
                slot.ClearItem();
            }

            var heldItems = PlayerObj.GetComponent<PlayerInventory>().HeldItems;
            
            foreach (var (name, sprite) in heldItems)
            {
                var emptySlot = InventoryItems.FirstOrDefault(x => x.ItemGuid.Equals(""));
                if (emptySlot != null) {
                    emptySlot.HoldItem(name, sprite);
                }
            }
        }
    }
}
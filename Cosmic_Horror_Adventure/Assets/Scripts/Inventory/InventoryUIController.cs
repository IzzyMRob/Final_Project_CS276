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
        private VisualElement m_Root;
        private VisualElement m_SlotContainer;
        private int numSlots = 24;
        private int CurrentSlot = 0;

        private void Awake()
        {
            //Store the root from the UI Document component
            m_Root = GetComponent<UIDocument>().rootVisualElement;

            //Search the root for the SlotContainer Visual Element
            m_SlotContainer = m_Root.Q<VisualElement>("SlotContainer");

            //Create 20 InventorySlots and add them as children to the SlotContainer
            for (int i = 0; i < numSlots; i++)
            {
                InventorySlot item = new InventorySlot();
                InventoryItems.Add(item);
                m_SlotContainer.Add(item);
            }
        }        

        public void AddToInventory(string name, Sprite sprite)
        {
            for (int i = 0; i < numSlots; i++)
            {
                InventorySlot item = new InventorySlot();
                InventoryItems.Add(item);
                m_SlotContainer.Add(item);
            }
            print(name);
            print(sprite);
            var emptySlot = InventoryItems[CurrentSlot];
            emptySlot.HoldItem(name, sprite);
            CurrentSlot ++;
        }
    }
}
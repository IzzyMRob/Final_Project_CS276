using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;
using UnityEngine.UIElements;

namespace Assets.WUG.Scripts
{
    public class InventorySlot : VisualElement
    {
        public Image Icon;
        public string ItemGuid = "";
        public Image ItemImage;

        public InventorySlot()
        {
            //Create a new Image element and add it to the root
            Icon = new Image();
            ItemImage = new Image();
            Add(Icon);
            Add(ItemImage);

            //Add USS style properties to the elements
            ItemImage.AddToClassList("itemImage");
            Icon.AddToClassList("slotIcon");
            AddToClassList("slotContainer");
        }

        public void HoldItem(string name, Sprite sprite)
        {
            Icon = new Image();
            Add(Icon);
            Debug.Log(name);
            Debug.Log(sprite);
            Icon.image = sprite.texture;
            ItemGuid = name;
        }
    }
}
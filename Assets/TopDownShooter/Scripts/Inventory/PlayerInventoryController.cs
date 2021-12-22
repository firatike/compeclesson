using System.Collections;
using System.Collections.Generic;
using TopDownShooter.Inventory;
using UnityEngine;

namespace TopDownShooter.PlayerControls
{
    public class PlayerInventoryController : MonoBehaviour
    {
        [SerializeField] private AbstractBasePlayerInventoryItemData[] _inventoryItemDataArray;
        public Transform Parent;

        private void Start()
        {
            //FOR TESTING PURPOSES ONLY 
            InitializeInventory(_inventoryItemDataArray);
        }

        public void InitializeInventory(AbstractBasePlayerInventoryItemData[] inventoryItemDataArray)
        {
            for (int i = 0; i < inventoryItemDataArray.Length; i++)
            {
                inventoryItemDataArray[i].CreateIntoInventory(this);
            }
        }

    }
}

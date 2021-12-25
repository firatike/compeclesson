using System.Collections;
using System.Collections.Generic;
using TopDownShooter.Inventory;
using UnityEngine;

namespace TopDownShooter.PlayerControls
{
    public class PlayerInventoryController : MonoBehaviour
    {
        [SerializeField] private AbstractBasePlayerInventoryItemData[] _inventoryItemDataArray;
        private List<AbstractBasePlayerInventoryItemData> _InstantiatedItemDataList;
        public Transform Parent;

        private void Start()
        {
            //FOR TESTING PURPOSES ONLY 
            InitializeInventory(_inventoryItemDataArray);
        }

        private void OnDestroy()
        {
            ClearInventory();
        }

        public void InitializeInventory(AbstractBasePlayerInventoryItemData[] inventoryItemDataArray)
        {
            ClearInventory();

            _InstantiatedItemDataList = new List<AbstractBasePlayerInventoryItemData>(inventoryItemDataArray.Length);
            for (int i = 0; i < inventoryItemDataArray.Length; i++)
            {
                var instantiated = Instantiate(inventoryItemDataArray[i]);
                instantiated.CreateIntoInventory(this);
                _InstantiatedItemDataList.Add(instantiated);
            }
        }

        private void ClearInventory()
        {
            if (_InstantiatedItemDataList != null)
            {
                for (int i = 0; i < _InstantiatedItemDataList.Count; i++)
                {
                    _InstantiatedItemDataList[i].Destroy();
                }
            }
        }
    }
}

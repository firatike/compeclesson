using System.Collections;
using System.Collections.Generic;
using TopDownShooter.PlayerControls;
using UnityEngine;

namespace TopDownShooter.Inventory 
{
    [CreateAssetMenu(menuName = "Topdown Shooter/Inventory/Player Inventory Body Item Data")]
    public class PlayerInventoryBodyItemData : AbstractPlayerInventoryItemData<PlayerInventoryBodyItemMono>
    {
        public override void CreateIntoInventory(PlayerInventoryController targetPlayerInventory)
        {
            var instantiated = InstantiateAndInitializePrefab(targetPlayerInventory.Parent);
        }
    }
}

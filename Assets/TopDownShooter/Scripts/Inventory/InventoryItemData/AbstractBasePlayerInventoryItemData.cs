using System.Collections;
using System.Collections.Generic;
using TopDownShooter.PlayerControls;
using UnityEngine;

namespace TopDownShooter.Inventory
{
    public abstract class AbstractBasePlayerInventoryItemData : ScriptableObject
    {
        public abstract void CreateIntoInventory(PlayerInventoryController targetPlayerInventory);

        public virtual void Destroy()
        {
            Destroy(this);
        }
    }
}
﻿using OUA.Items.Inventories;
using System;

namespace OUA.Items
{
    [Serializable]
    public struct ItemSlot
    {
        public InventoryItem item;
        public int quantity;

        public ItemSlot(InventoryItem item, int quantity)
        {
            this.item = item;
            this.quantity = quantity;
        }
    }
}

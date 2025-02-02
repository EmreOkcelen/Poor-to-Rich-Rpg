﻿using OUA.Items.Inventories;
using System.Text;
using UnityEngine;

namespace OUA.Items
{
    [CreateAssetMenu(fileName = "New Ammunition", menuName = "Items/Ammunition")]
    public class Ammunition : InventoryItem
    {
        [SerializeField] private GameObject ammunitionPrefab = null;

        public GameObject AmmunitionPrefab => ammunitionPrefab;

        public override string GetInfoDisplayText()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append(ItemUsageType.Name).AppendLine();
            builder.Append("Max Stack: ").Append(MaxStack).AppendLine();
            builder.Append("Sell Price: ").Append(SellPrice).Append(" Gold");

            return builder.ToString();
        }
    }
}

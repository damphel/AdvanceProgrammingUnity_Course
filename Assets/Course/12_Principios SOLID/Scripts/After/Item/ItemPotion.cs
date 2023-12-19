using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course.SOLID.After
{
    public class ItemPotion : Item
    {
        public override void ExecuteMessage()
        {
            Debug.Log($"{itemName}: Drink to get more power!");
        }
    }
}
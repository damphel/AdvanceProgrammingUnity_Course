using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course.SOLID.After
{
    public class ItemWeapon : Item
    {
        public override void ExecuteMessage()
        {
            Debug.Log($"{itemName}: Shoot!");
        }
    }
}
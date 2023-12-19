using UnityEngine;

namespace Course.SOLID.After
{
    public class ItemShield : Item
    {
        public override void ExecuteMessage()
        {
            Debug.Log($"{itemName}: Defense!");
        }
    }
}

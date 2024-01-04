using UnityEngine;

namespace Course.PatronesDiseno.NullObject
{
    public class WeaponNull : Weapon
    {
        public override void Attack(IDamage damageReceiver)
        {
            // Do nothing
            Debug.Log($"This weapon is null");
        }
    }
}

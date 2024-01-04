using UnityEngine;

namespace Course.PatronesDiseno.Template
{
    public class Orc : Character
    {
        protected override bool CanAttack()
        {
            return true;
        }

        protected override void DoAttack()
        {
            // Attack
        }

        protected override void DamageReceived(bool isDead)
        {
            if (isDead)
            {
                // Drop some item or currency
                return;
            }

            Debug.Log("HA HA HA!");
        }

    }
}

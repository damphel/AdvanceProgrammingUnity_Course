using UnityEngine;

namespace Course.PatronesDiseno.Template
{
    public class Elf : Character
    {
        protected override bool CanAttack()
        {
            if (health >= 30)
            {
                return true;
            }

            Debug.Log("I can't attack - I'm too weak!");
            return false;
        }

        protected override void DoAttack()
        {
            // Attack
        }

        protected override void DamageReceived(bool isDead)
        {
            if (isDead)
            {
                // Game Over
            }
        }

    }
}

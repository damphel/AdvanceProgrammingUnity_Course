using UnityEngine;

namespace Course.PatronesDiseno.Template
{
    public abstract class Character : MonoBehaviour
    {
        protected int health = 100;

        public void Attack()
        {
            if (CanAttack())
            {
                DoAttack();
            }
        }

        protected abstract bool CanAttack();
        protected abstract void DoAttack();

        public void ReceiveDamage (int damage)
        {
            bool isDead = ApplyDamage(damage);
            DamageReceived(isDead);
        }

        private bool ApplyDamage(int damage) 
        {
            health -= damage;
            if (health > 0)
            {
                return false;
            }

            health = 0;
            return true;
        }

        protected abstract void DamageReceived(bool isDead);
    
    }
}

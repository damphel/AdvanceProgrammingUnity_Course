using UnityEngine;

namespace Course.EstructurasDeControl
{
    public class IfElse : MonoBehaviour
    {
        public bool canAttack;

        private void Attack()
        {
            if (canAttack)
            {
                Debug.Log("Attack!");
            }
            else
            {
                Debug.Log("I can't attack.");
            }

            Debug.Log(canAttack ? "Attack!" : "I can't attack."); // Operador Ternario

            if (canAttack)
                Debug.Log("Attack!");

            if (canAttack) Debug.Log("Attack!");
        }

        public int currentAmmo;
        public int totalAmmo;

        private void CheckAmmo()
        {
            if (currentAmmo > 0)
            {
                // Shoot
            }

            if (totalAmmo == 0 || currentAmmo <= 0)
            {
                // Require ammo
            }
        }

        public SphereCollider shieldCollider;

        private void Defense()
        {
            if (shieldCollider != null)
            {
                // Use shield
            }

            if (shieldCollider)
            {
                // Use shield
            }
        }
    }
}

using UnityEngine;

namespace Course.PatronesDiseno.NullObject
{
    public class Character : MonoBehaviour
    {
        private Weapon currentWeapon;
        private IDamage currentTarget;

        private void Awake()
        {
            currentWeapon = new WeaponNull();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space)) Attack();
        }

        public void Attack()
        {
            currentWeapon.Attack(currentTarget);
        }

    }
}

using System;
using UnityEngine;

namespace Course.PatronesDiseno.Strategy
{
    public class Character : MonoBehaviour, IDamage
    {
        public GameObject weaponPrefab;

        private IWeapon _weapon;

        private void Start()
        {
            EquipWeapon();
        }

        private void EquipWeapon()
        {
            _weapon = Instantiate(weaponPrefab, transform).GetComponent<IWeapon>();

            if (_weapon == null)
                throw new Exception($"Prefab {weaponPrefab.name} does not implement IWeapon interface");
        }

        public void DoDamage(int damage)
        {
            Debug.Log("Receive Damage", this);
        }

        private void Attack()
        {
            _weapon.Attack();
        }
    }
}

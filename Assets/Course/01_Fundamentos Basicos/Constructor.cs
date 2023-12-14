using UnityEngine;

namespace Course.FundamentosBasicos
{
    public class Constructor : MonoBehaviour
    {
        private void Start()
        {
            Weapon myWeapon = new Weapon(100);

            myWeapon.Shoot();
        }
    }

    public class Weapon
    {
        int ammo;

        public Weapon()
        {
            ammo = 30;
        }

        public Weapon(int ammo)
        {
            this.ammo = ammo;
        }

        public void Shoot()
        {

        }
    }
}

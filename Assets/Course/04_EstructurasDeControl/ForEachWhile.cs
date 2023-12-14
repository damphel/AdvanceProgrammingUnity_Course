using System.Collections;
using UnityEngine;

namespace Course.EstructurasDeControl
{
    public class ForEachWhile : MonoBehaviour
    {
        public int[] weaponAmmoArray;

        private void CheckWeaponAmmo()
        {
            for (int i = 0; i < weaponAmmoArray.Length; i++)
            {
                Debug.Log($"Index {i} - Ammo: {weaponAmmoArray[i]}");
            }

            foreach (int weaponAmmo in weaponAmmoArray)
            {
                Debug.Log($"Index ? - Ammo: {weaponAmmo}");
            }
        }

        private IEnumerator Fade()
        {
            float alpha = 1;

            while (alpha > 0)
            {
                alpha -= Time.deltaTime * 1;
                yield return null;
            }

            // Do something
        }


    }
}

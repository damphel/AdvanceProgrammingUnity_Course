using UnityEngine;

namespace Course.PatronesDiseno.Strategy
{
    public class Bow : MonoBehaviour, IWeapon
    {
        public GameObject arrowPrefab;
        public Transform spawnTransform;

        public void Attack()
        {
            Instantiate(arrowPrefab, spawnTransform.position, spawnTransform.rotation);
        }
    }
}

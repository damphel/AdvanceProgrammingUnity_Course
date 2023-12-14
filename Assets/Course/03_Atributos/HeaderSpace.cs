using UnityEngine;

namespace Course.Atributos
{
    public class HeaderSpace : MonoBehaviour
    {
        [Header("Stats")]
        public string displayName;
        [Space]
        public int health;
        public int mana;
        [Space(50)]
        public bool isAlive;

        [Header("References")]
        public CapsuleCollider capsuleCollider;
    }
}

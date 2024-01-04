using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course.SOLID.Before
{
    public class Enemy : MonoBehaviour, ICharacter
    {
        public string enemyName;

        public void Damage(int value)
        {
            Debug.Log($"Enemy receive {value} damage!");
        }

        public void Heal(int value)
        {
            // None
        }

        public void Interact()
        {
            // None
        }

        private void OnTriggerEnter(Collider other)
        {
            ICharacter otherCharacter = other.GetComponent<ICharacter>();

            if (otherCharacter != null)
            {
                otherCharacter.Damage(15);
            }
        }

    }
}

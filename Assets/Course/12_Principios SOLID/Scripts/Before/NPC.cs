using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course.SOLID.Before
{
    public class NPC : MonoBehaviour, ICharacter
    {
        public string npcName;
        private ICharacter otherCharacter;

        public void Damage(int value)
        {
            // None
        }

        public void Heal(int value)
        {
            // None
        }

        public void Interact()
        {
            if (otherCharacter != null)
            {
                otherCharacter.Heal(500);
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            otherCharacter = other.GetComponent<ICharacter>();
        }

        private void OnTriggerExit(Collider other)
        {
            otherCharacter = null;
        }
    }
}

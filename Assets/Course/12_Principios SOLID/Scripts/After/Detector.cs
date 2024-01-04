using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course.SOLID.After
{
    public class Detector : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            Character otherCharacter = other.GetComponent<Character>();

            if (otherCharacter != null)
            {
                Debug.Log($"Name: {otherCharacter.characterName}");
            }
        }
    }
}

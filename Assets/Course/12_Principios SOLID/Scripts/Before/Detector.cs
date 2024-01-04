using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course.SOLID.Before
{
    public class Detector : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            Player otherPlayer = other.GetComponent<Player>();

            if (otherPlayer != null)
            {
                Debug.Log($"Name: {otherPlayer.playerName}");
            }

            Enemy otherEnemy = other.GetComponent<Enemy>();

            if (otherEnemy != null)
            {
                Debug.Log($"Name: {otherEnemy.enemyName}");
            }

            NPC otherNPC = other.GetComponent<NPC>();

            if (otherNPC != null)
            {
                Debug.Log($"Name: {otherNPC.npcName}");
            }
        }
    }
}

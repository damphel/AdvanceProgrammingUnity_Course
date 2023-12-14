 using UnityEngine;

namespace Course.EstructurasDeControl
{
    public struct PlayerData
    {
        public int score;
        public bool isAlive;
    }

    public class JumpStatements : MonoBehaviour
    {
        public PlayerData[] playersData;

        private void CheckMaxScore()
        {
            for (int i = 0; i < playersData.Length; i++)
            {
                if (playersData[i].score >= 10)
                {
                    // Winner
                    break;
                }
            }
        }

        private void CheckPlayersScore()
        {
            for (int i = 0; i < playersData.Length; i++)
            {
                if (!playersData[i].isAlive)
                {
                    continue;
                }
                 
                // Other Logic
            }
        }

        private void CheckPlayerScore(int index)
        {
            if (!playersData[index].isAlive)
            {
                return; // Early Exit
            }

            // Other Logic
        }
    }
}

using UnityEngine;

[System.Serializable]
public struct PlayerData
{
    public string name;
    public int health;
    public bool isDead;
    public int ammo;
}


namespace Course.FundamentosBasicos
{
    public class TipoStruct : MonoBehaviour
    {
        public string playerName;
        public int playerHealth;
        public bool playerIsDead;


        public PlayerData playerData;

        private void Start()
        {
            playerData.name = "Mariano";
            playerData.health = 100;
            playerData.isDead = false;
        }
    }
}

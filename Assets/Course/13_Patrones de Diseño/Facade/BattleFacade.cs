using UnityEngine;

namespace Course.PatronesDiseno.Facade
{
    public class BattleFacade : MonoBehaviour
    {
        public BattleUI battleUI;
        public CharacterSpawner characterSpawner;
        public CharacterUI characterUI;

        public void BattleStart()
        {
            battleUI.Show();

            characterSpawner.SpawnPlayers();
            characterSpawner.SpawnEnemies();

            characterUI.ShowPlayersUI();
            characterUI.ShowEnemiesUI();

            battleUI.Hide();
        }

        public void BattleEnd()
        {
            battleUI.Show();

            characterSpawner.DestroyPlayers();
            characterSpawner.DestroyEnemies();

            characterUI.HidePlayersUI();
            characterUI.HideEnemiesUI();

            battleUI.Hide();
        }
    }
}

using UnityEngine;

namespace Course.PatronesDiseno.Facade
{
    public class GameManager : MonoBehaviour
    {
        public BattleFacade battleFacade;

        public void BattleStart()
        { 
            battleFacade.BattleStart();
        }

        public void BattleEnd()
        {
            battleFacade.BattleEnd();
        }
    }
}

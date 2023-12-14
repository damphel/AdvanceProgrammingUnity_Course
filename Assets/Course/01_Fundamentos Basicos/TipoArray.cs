using UnityEngine;

namespace Course.FundamentosBasicos
{
    public class TipoArray : MonoBehaviour
    {
        public int[] enemyId = { 100, 200, 300, 400 };

        private void Start()
        {
            int myId = enemyId[0]; //100
            
            myId = enemyId[3]; //400
        }
    }
}

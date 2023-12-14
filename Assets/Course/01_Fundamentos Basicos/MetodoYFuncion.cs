using UnityEngine;

namespace Course.FundamentosBasicos
{
    public class MetodoYFuncion : MonoBehaviour
    {
        private void Start()
        {
            // Do something
            Shoot(weaponType: 2);

            int myId;
            myId = GetPlayerId(); // 10
            ChangePlayerIdWithOut(out myId); // 20
            ChangePlayerIdWithRef(ref myId); // 30
        }

        public void Shoot(int amountBullets = 5, int weaponType = 0)
        {
            // Do something
        }

        private int GetPlayerId()
        {
            // Do something
            return 10;
        }

        private void ChangePlayerIdWithOut(out int id)
        {
            // Do something
            id = 20;
        }

        private void ChangePlayerIdWithRef(ref int id)
        {
            // Do something
            id = 30;
        }
    }
}

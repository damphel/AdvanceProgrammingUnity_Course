using UnityEngine;

public enum AttackType
{
    None,
    Fire,
    Ice,
    Sword,
    Punch
}

namespace Course.FundamentosBasicos
{
    public class TipoEnum : MonoBehaviour
    {
        // 0 = Fire
        // 1 = Ice
        // 2 = Sword
        // 3 = Punch
        public int attackTypeInt;

        public AttackType attackTypeEnum = AttackType.Sword;
    }
}

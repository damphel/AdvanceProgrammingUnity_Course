using UnityEngine;

namespace Course.POO
{
    public class EnemyOrc : Enemy
    {
        public override void Attack()
        {
            damage = 999;

            base.Attack();

            Debug.Log("I'm an orc!");
        }

        public override void Defense()
        {
            Debug.Log($"Enemy '{_title}' DEFENSE. Health: '{health}'");
        }
    }
}

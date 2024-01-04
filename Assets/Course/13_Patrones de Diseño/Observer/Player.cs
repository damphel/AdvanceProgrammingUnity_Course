using UnityEngine;
using UnityEngine.Events;
using TMPro;

namespace Course.PatronesDiseno.Observer
{
    public class Player : MonoBehaviour
    {
        private int _health = 100;

        public UnityEvent<int> OnUpdateHealth;

        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                _health = value;
                OnUpdateHealth.Invoke(_health);
            }
        }

        public void ApplyDamage(int damage)
        {
            Health -= damage;
        }
    }
}

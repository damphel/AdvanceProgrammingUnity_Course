using System;
using UnityEngine;

namespace Course.PatronesDiseno.ObjectPool
{
    [RequireComponent(typeof(Rigidbody))]
    public class Bullet : MonoBehaviour
    {
        private float speed = 10;
        private Action<Bullet> OnKill;

        public void Init(Action<Bullet> actionKill)
        {
            OnKill = actionKill;

            Rigidbody rigidbody = GetComponent<Rigidbody>();
            rigidbody.velocity = transform.forward * speed;
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Wall"))
            {
                OnKill(this);
            }
        }
    }
}

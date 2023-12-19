using UnityEngine;
using UnityEngine.Events;

namespace Course.SOLID.After
{
    public class PlayerInput : MonoBehaviour
    {
        public InputHandler inputHandler;
        [Space]
        public float speedMovement = 15f;
        [Space]
        public UnityEvent OnInteract;
        public UnityEvent OnConsumeItem;

        private void Update()
        {
            // Movement
            ActionMovement();

            // Interaction
            ActionInteraction();

            // Consume Item
            ActionConsumeItem();
        }

        private void ActionMovement()
        {
            float inputHorizontal = inputHandler.GetAxisHorizontal();

            Vector3 direction = new Vector3(inputHorizontal, 0, 0);

            transform.Translate(direction * speedMovement * Time.deltaTime);
        }

        private void ActionInteraction()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                OnInteract.Invoke();
            }
        }

        private void ActionConsumeItem()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                OnConsumeItem.Invoke();
            }
        }

    }
}

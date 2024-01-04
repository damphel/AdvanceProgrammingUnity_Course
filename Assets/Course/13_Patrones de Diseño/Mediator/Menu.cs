using UnityEngine;

namespace Course.PatronesDiseno.Mediator
{
    public abstract class Menu : MonoBehaviour
    {
        public MenuMediator mediator;

        public abstract void Show();
        public abstract void Hide();
    }
}

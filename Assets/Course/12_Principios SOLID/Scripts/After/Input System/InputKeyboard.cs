using UnityEngine;

namespace Course.SOLID.After
{
    public class InputKeyboard : InputHandler
    {
        public override float GetAxisHorizontal()
        {
            return Input.GetAxis("Horizontal");
        }
    }
}

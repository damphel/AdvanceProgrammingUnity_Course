using UnityEngine;

namespace Course.SOLID.After
{
    public class InputKey : InputHandler
    {
        public KeyCode keyLeft = KeyCode.LeftArrow;
        public KeyCode keyRight = KeyCode.RightArrow;

        public override float GetAxisHorizontal()
        {
            if (Input.GetKey(keyLeft))
            {
                return -1;
            }

            if (Input.GetKey(keyRight))
            {
                return 1;
            }

            return 0;
        }
    }
}

using UnityEngine;

namespace Course.EstructurasDeControl
{
    public enum EPlatform
    {
        None,
        PC,
        Xbox,
        Playstation,
        Switch
    }

    public class Switcher : MonoBehaviour
    {
        public int weaponType;
        public string enemyClass;
        public EPlatform currentPlatform;

        private void Start()
        {
            switch (currentPlatform)
            {
                case EPlatform.None:
                    break;
                case EPlatform.PC:
                    break;
                case EPlatform.Xbox:
                    break;
                case EPlatform.Playstation:
                    break;
                case EPlatform.Switch:
                    break;
                default:
                    break;
            }
        }

    }
}

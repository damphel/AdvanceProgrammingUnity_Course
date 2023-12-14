using UnityEngine;

namespace Course.Atributos
{
    public class TextAreaMultiline : MonoBehaviour
    {
        [TextArea(1, 10)]
        public string description;

        [Multiline(6)]
        public string note;
    }
}

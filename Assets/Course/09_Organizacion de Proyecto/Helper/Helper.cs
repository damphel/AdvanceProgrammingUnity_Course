using UnityEngine;
using UnityEngine.Tools;

namespace Course.OrganizacionProyecto
{
    public class Helper : MonoBehaviour
    {
        private void Start()
        {
            RectTransform test = CourseTools.GetRectTransform(transform);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Tools
{
    public static class CourseTools
    {
        public static RectTransform GetRectTransform(this Transform t)
        {
            return t as RectTransform;
        }
    }
}

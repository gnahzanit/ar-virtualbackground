using UnityEngine;

namespace UnityEngine.XR.ARFoundation.Samples
{
    public enum MenuType
    { 
        Depth
    }

    public static class ActiveMenu
    {
        public static MenuType currentMenu { get; set; }
    }
}

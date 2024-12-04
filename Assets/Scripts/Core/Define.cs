using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public static class Define
    {
        private static Camera _mainCamera;
        public static Camera MainCamera
        {
            get
            {
                if(_mainCamera == null)
                {
                    _mainCamera = Camera.main;
                }
                return _mainCamera;
            }
            set=> _mainCamera = value;
        }
    }
}


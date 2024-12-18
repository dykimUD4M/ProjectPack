using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _instance;

    public static T Instance
    {
        get
        {
            if( _instance == null )
            {
                _instance = FindObjectOfType<T>();
                if( _instance == null )
                {
                    Debug.LogError($"An object of type({typeof(T).Name}) does not exist.");
                }
            }

            return _instance;
        }
    }

}

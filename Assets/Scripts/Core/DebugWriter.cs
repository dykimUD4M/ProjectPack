using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugWriter
{
    public static void Print(string msg)
    {
#if UNITY_EDITOR
        Debug.Log(msg);
#endif
    }

    public static void PrintWarning(string msg)
    {
#if UNITY_EDITOR
        Debug.LogWarning(msg);
#endif
    }

    public static void PrintError(string msg)
    {
#if UNITY_EDITOR
        Debug.LogError(msg);
#endif
    }
}

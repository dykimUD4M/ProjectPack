using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UIEvent
{
    None,
    //Btn
    //Status
    Final,
}

public class UIManager : Singleton<UIManager>
{
    private Dictionary<UIEvent, Action<EventParam>> eventDictionary = new Dictionary<UIEvent, Action<EventParam>>();

    public void ListenEvent(UIEvent eventName, Action<EventParam> action)
    {
        if (eventDictionary.ContainsKey(eventName))
        {
            eventDictionary[eventName] += action;
        }
        else
        {
            eventDictionary.Add(eventName, action);
        }
    }

    public void RemoveEvent(UIEvent eventName, Action<EventParam> action)
    {
        if (eventDictionary.ContainsKey(eventName))
        {
            eventDictionary[eventName] -= action;
        }
        else
        {
            Debug.LogError($"There is no event function to delete. | EventName : {eventName}");
        }
    }

    public void TriggerEvent(UIEvent eventName, EventParam param)
    {
        if (eventDictionary.ContainsKey(eventName))
        {
            eventDictionary[eventName]?.Invoke(param);
        }
        else
        {
            Debug.LogError($"There is no event function to trigger. | EventName : {eventName}");
        }
    }
}

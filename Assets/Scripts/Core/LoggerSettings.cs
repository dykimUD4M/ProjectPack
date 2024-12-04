using UnityEngine;

[CreateAssetMenu(fileName = "LoggerSettings", menuName = "LogSystem/LoggerSettings")]
public class LoggerSettings : ScriptableObject
{
    public Logger.LogLevel LipSync;
    public Logger.LogLevel Character;
    public Logger.LogLevel Actions;
    public Logger.LogLevel UI;
    public Logger.LogLevel GRPC;
    public Logger.LogLevel Editor;
}
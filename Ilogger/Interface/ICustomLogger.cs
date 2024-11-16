namespace ILogger.Interface;
public interface ICustomLogger
{
    void LogInformation(string message);
    void LogWarning(string message);
    void LogError(string message);
    void Log(LogLevel level, string message);
}

using ILogger.Interface;
public class CustomLogger : ICustomLogger
{
    private readonly string _logFilePath;

    public CustomLogger(string logFilePath = "../../../Logs")
    {
        if (!Directory.Exists(logFilePath))
        {
            Directory.CreateDirectory(logFilePath);
        }

        _logFilePath = Path.Combine(logFilePath, $"log_{DateTime.Now:dd.MM.yyyy}.log");
    }

    public void LogInformation(string message)
    {
        Log(LogLevel.Info, message);
    }

    public void LogError(string message)
    {
        Log(LogLevel.Error, message);
    }

    public void LogWarning(string message)
    {
        Log(LogLevel.Warning, message);
    }
    public void Log(LogLevel level, string message)
    {
        string formattedMessage = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [{level}] {message}";

        Console.WriteLine(formattedMessage);

        try
        {
            File.AppendAllText(_logFilePath, formattedMessage + Environment.NewLine);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Faylga yozishda xatolik: {ex.Message}");
        }
    }
}

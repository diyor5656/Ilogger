using ILogger.Interface;

ICustomLogger logger = new CustomLogger();

logger.LogInformation("Console dasturi boshlandi.");
logger.LogWarning("Bu ogohlantirish logi.");
logger.LogError("Bu xato logi.");

Console.WriteLine("\nHello World");


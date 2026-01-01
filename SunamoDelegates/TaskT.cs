// variables names: ok
namespace SunamoDelegates;

#if ASYNC
/// <summary>
/// Represents a method that takes a value of type T and returns a Task.
/// </summary>
/// <typeparam name="T">The type of the value parameter.</typeparam>
/// <param name="value">The value of type T.</param>
/// <returns>A task representing the asynchronous operation.</returns>
public delegate Task TaskT<T>(T value);
#else
/// <summary>
/// Represents a method that takes a value of type T and returns void.
/// </summary>
/// <typeparam name="T">The type of the value parameter.</typeparam>
/// <param name="value">The value of type T.</param>
public delegate void TaskT<T>(T value);
#endif
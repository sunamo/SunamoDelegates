// variables names: ok
namespace SunamoDelegates;

#if ASYNC
/// <summary>
/// Represents a method that takes a nullable boolean parameter and returns a Task.
/// </summary>
/// <param name="isEnabled">The nullable boolean value indicating enabled state.</param>
/// <returns>A task representing the asynchronous operation.</returns>
public delegate Task TaskBoolNullable(bool? isEnabled);
#else
/// <summary>
/// Represents a method that takes a nullable boolean parameter and returns void.
/// </summary>
/// <param name="isEnabled">The nullable boolean value indicating enabled state.</param>
public delegate void TaskBoolNullable(bool? isEnabled);
#endif
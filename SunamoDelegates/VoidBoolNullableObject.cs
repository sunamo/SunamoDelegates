// variables names: ok
namespace SunamoDelegates;

/// <summary>
/// Represents a method that takes a nullable boolean and an object parameter, and returns void.
/// </summary>
/// <param name="isEnabled">The nullable boolean value indicating enabled state.</param>
/// <param name="parameter">The object parameter.</param>
public delegate void VoidBoolNullableObject(bool? isEnabled, object parameter);
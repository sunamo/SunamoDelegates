// variables names: ok
namespace SunamoDelegates;

/// <summary>
/// Represents a method that takes a string and a value of type T, and returns void.
/// </summary>
/// <typeparam name="T">The type of the value parameter.</typeparam>
/// <param name="text">The input text.</param>
/// <param name="value">The value of type T.</param>
public delegate void VoidStringT<T>(string text, T value);
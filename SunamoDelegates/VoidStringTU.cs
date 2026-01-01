// variables names: ok
namespace SunamoDelegates;

/// <summary>
/// Represents a method that takes a string and two values of different types, and returns void.
/// </summary>
/// <typeparam name="T">The type of the first value parameter.</typeparam>
/// <typeparam name="U">The type of the second value parameter.</typeparam>
/// <param name="text">The input text.</param>
/// <param name="firstValue">The first value of type T.</param>
/// <param name="secondValue">The second value of type U.</param>
public delegate void VoidStringTU<T, U>(string text, T firstValue, U secondValue);
// variables names: ok
namespace SunamoDelegates;

/// <summary>
/// Represents a method that takes a string and a byte array, and returns a string.
/// </summary>
/// <param name="text">The input text.</param>
/// <param name="array">The byte array.</param>
/// <returns>A string result.</returns>
public delegate string StringStringByteArrayHandler(string text, byte[] array);
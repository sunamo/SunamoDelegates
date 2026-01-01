// variables names: ok
namespace SunamoDelegates;

/// <summary>
/// Represents a method that takes two byte arrays and returns a string.
/// </summary>
/// <param name="firstArray">The first byte array.</param>
/// <param name="secondArray">The second byte array.</param>
/// <returns>A string result.</returns>
public delegate string StringByteArrayByteArrayHandler(byte[] firstArray, byte[] secondArray);
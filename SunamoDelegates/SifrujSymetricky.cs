// variables names: ok
namespace SunamoDelegates;

/// <summary>
/// Represents a method for symmetric encryption that takes plain text bytes, passphrase, salt, and initialization vector.
/// </summary>
/// <param name="plainTextBytes">The plain text bytes to encrypt.</param>
/// <param name="passPhrase">The passphrase for encryption.</param>
/// <param name="saltValueBytes">The salt value bytes.</param>
/// <param name="initVectorBytes">The initialization vector bytes.</param>
/// <returns>The encrypted byte array.</returns>
public delegate byte[] SifrujSymetricky(byte[] plainTextBytes, string passPhrase, byte[] saltValueBytes,
    byte[] initVectorBytes);
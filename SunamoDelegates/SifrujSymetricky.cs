namespace SunamoDelegates;

/// <summary>
/// Represents the encrypt symmetric type.
/// </summary>
public delegate byte[] EncryptSymmetric(byte[] plainTextBytes, string passPhrase, byte[] saltValueBytes,
    byte[] initVectorBytes);

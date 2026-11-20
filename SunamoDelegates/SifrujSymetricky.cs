namespace SunamoDelegates;

public delegate byte[] EncryptSymmetric(byte[] plainTextBytes, string passPhrase, byte[] saltValueBytes,
    byte[] initVectorBytes);

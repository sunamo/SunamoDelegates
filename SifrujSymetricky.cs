
namespace SunamoDelegates;
public delegate byte[] SifrujSymetricky(byte[] plainTextBytes, string passPhrase, byte[] saltValueBytes,
byte[] initVectorBytes);
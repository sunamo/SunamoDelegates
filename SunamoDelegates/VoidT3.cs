// variables names: ok
namespace SunamoDelegates;

/// <summary>
/// Represents a method that takes three values of different types and returns void.
/// </summary>
/// <typeparam name="T">The type of the first value parameter.</typeparam>
/// <typeparam name="U">The type of the second value parameter.</typeparam>
/// <typeparam name="Z">The type of the third value parameter.</typeparam>
/// <param name="firstValue">The first value of type T.</param>
/// <param name="secondValue">The second value of type U.</param>
/// <param name="thirdValue">The third value of type Z.</param>
public delegate void VoidT3<T, U, Z>(T firstValue, U secondValue, Z thirdValue);
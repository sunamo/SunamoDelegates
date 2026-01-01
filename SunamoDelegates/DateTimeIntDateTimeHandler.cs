// variables names: ok
namespace SunamoDelegates;

/// <summary>
/// Represents a method that takes an integer value and a DateTime, and returns a DateTime.
/// </summary>
/// <param name="value">The integer value.</param>
/// <param name="dateTime">The DateTime value.</param>
/// <returns>A DateTime result.</returns>
public delegate DateTime DateTimeIntDateTimeHandler(int value, DateTime dateTime);
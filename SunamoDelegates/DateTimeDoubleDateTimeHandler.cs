// variables names: ok
namespace SunamoDelegates;

/// <summary>
/// Represents a method that takes a double value and a DateTime, and returns a DateTime.
/// </summary>
/// <param name="value">The double value.</param>
/// <param name="dateTime">The DateTime value.</param>
/// <returns>A DateTime result.</returns>
public delegate DateTime DateTimeDoubleDateTimeHandler(double value, DateTime dateTime);
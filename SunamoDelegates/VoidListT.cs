// variables names: ok
namespace SunamoDelegates;

/// <summary>
/// Represents a method that takes a list of type T and returns void.
/// </summary>
/// <typeparam name="T">The type of elements in the list.</typeparam>
/// <param name="list">The list of type T.</param>
public delegate void VoidListT<T>(List<T> list);
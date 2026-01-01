// variables names: ok
// EN: WARNING - This delegate has a bug: parameter type should be UIElement (from WPF/UWP), not VoidUIElement
// CZ: VAROVÁNÍ - Tento delegate má chybu: typ parametru by měl být UIElement (z WPF/UWP), ne VoidUIElement
namespace SunamoDelegates;

/// <summary>
/// Represents a method that takes a VoidUIElement parameter and returns void.
/// WARNING: This delegate has a bug - the parameter type should be UIElement (from WPF/UWP), not VoidUIElement.
/// </summary>
/// <param name="element">The VoidUIElement parameter (should be UIElement).</param>
public delegate void VoidUIElement(VoidUIElement element);
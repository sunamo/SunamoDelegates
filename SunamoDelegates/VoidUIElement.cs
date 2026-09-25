namespace SunamoDelegates;

// variables names: ok

/// <summary>
/// Represents a method that takes a UI element parameter and returns void.
/// Uses object type since UIElement is platform-specific (WPF/UWP).
/// </summary>
/// <param name="element">The UI element.</param>
public delegate void VoidUIElement(object element);
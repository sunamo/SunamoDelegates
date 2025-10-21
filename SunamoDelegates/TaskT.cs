// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
namespace SunamoDelegates;
#if ASYNC
public delegate Task TaskT<T>(T t);
#else
public delegate void TaskT<T>(T t);
#endif
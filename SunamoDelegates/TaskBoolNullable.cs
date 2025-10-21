// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
namespace SunamoDelegates;
#if ASYNC
public delegate Task TaskBoolNullable(bool? b);
#else
public delegate void TaskBoolNullable(bool? b);
#endif
namespace SunamoDelegates;

#if ASYNC
public delegate Task TaskBoolNullable(bool? value);
#else
public delegate void TaskBoolNullable(bool? value);
#endif
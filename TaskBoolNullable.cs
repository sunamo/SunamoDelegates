namespace SunamoDelegates;
#if ASYNC
public delegate Task TaskBoolNullable(bool? b);
#else
public delegate void TaskBoolNullable(bool? b);
#endif
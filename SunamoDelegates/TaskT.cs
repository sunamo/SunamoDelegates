namespace SunamoDelegates;

#if ASYNC
public delegate Task TaskT<T>(T value);
#else
public delegate void TaskT<T>(T value);
#endif
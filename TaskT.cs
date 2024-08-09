namespace SunamoDelegates;
#if ASYNC
public delegate Task TaskT<T>(T t);
#else
public delegate void TaskT<T>(T t);
#endif

namespace SunamoDelegates;
#if ASYNC
public delegate Task TaskVoid();
#else
public delegate void TaskVoid();
#endif

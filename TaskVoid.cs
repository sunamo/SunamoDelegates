namespace
#if SunamoCl
SunamoCl
#elif SunamoBts
SunamoBts
#elif SunamoShared
SunamoShared
#elif SunamoAsync
SunamoAsync
#else
SunamoDelegates
#endif
;
#if ASYNC
public delegate Task TaskVoid();
#else
public delegate void TaskVoid();
#endif

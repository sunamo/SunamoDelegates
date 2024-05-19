namespace
#if SunamoCl
SunamoCl
#elif SunamoBts
SunamoBts
#elif SunamoShared
SunamoShared
#elif SunamoAsync
SunamoAsync
#elif SunamoExceptions
SunamoExceptions
#else
SunamoDelegates
#endif
;
#if ASYNC
public delegate Task TaskVoid();
#else
public delegate void TaskVoid();
#endif
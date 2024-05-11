
namespace
#if SunamoCl
SunamoCl
#elif SunamoBts
SunamoBts
#elif SunamoAsync
SunamoAsync
#else
SunamoDelegates
#endif
;
public delegate void VoidVoid();
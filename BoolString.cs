
namespace
#if SunamoHttp
SunamoHttp
#elif SunamoShared
SunamoShared
#elif SunamoUri
SunamoUri
#else SunamoDelegates
SunamoDelegates
#endif
;
public delegate bool BoolString(string s);
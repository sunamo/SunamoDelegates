
namespace
#if SunamoFileSystem
SunamoFileSystem
#else SunamoDelegates
SunamoDelegates
#endif
;
public delegate void VoidStringT<T>(string s, T t);
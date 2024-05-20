namespace
#if SunamoFileSystem
SunamoFileSystem
#else
SunamoDelegates
#endif
;
public delegate void VoidStringT<T>(string s, T t);
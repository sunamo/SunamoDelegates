
namespace
#if SunamoShared
SunamoShared
#elif SunamoInterfaces
SunamoInterfaces
#elif SunamoInterfaces
SunamoInterfaces
#else
SunamoDelegates
#endif
;
public delegate void VoidBoolNullable(bool? b);
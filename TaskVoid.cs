using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace
#if SunamoCl
SunamoCl
#elif SunamoShared
SunamoShared
#else
SunamoDelegates
#endif
;
#if ASYNC
public delegate Task TaskVoid();
#else
public delegate void TaskVoid();
#endif

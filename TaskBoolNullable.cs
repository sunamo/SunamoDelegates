using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunamoDelegates;
#if ASYNC
public delegate Task TaskBoolNullable(bool? b);
#else
public delegate void TaskBoolNullable(bool? b);
#endif

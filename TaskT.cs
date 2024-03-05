using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunamoDelegates;
#if ASYNC
public delegate Task TaskT<T>(T t);
#else
public delegate void TaskT<T>(T t);
#endif
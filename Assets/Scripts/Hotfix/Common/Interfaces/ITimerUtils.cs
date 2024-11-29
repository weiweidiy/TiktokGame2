//using Sirenix.OdinInspector;

using System;

namespace JFrame.Common
{
    public interface ITimerUtils
    {
        ITimer Regist(float interval, int loopTimes, Action action, bool immediatly = false, bool useRealTime = false);
    }
}

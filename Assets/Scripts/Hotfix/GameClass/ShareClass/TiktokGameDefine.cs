using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tiktok
{
    public enum LevelState
    {
        Locked = 0,
        Unlocked = 1 << 0, //已解锁
        Completed = 1 << 1, //已完成
    }

}


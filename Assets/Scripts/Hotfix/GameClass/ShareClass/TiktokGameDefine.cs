using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tiktok
{
    public enum LevelState
    {
        Locked = 0,
        Unlocked = 1 << 0, //�ѽ���
        Completed = 1 << 1, //�����
    }

}


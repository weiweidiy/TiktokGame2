﻿/*
* 此类由ConfigTools自动生成. 不要手动修改!
*/
using System.Collections;
using System.Collections.Generic;
using JFramework.Game;

namespace JFramework
{
    public partial class LevelsCfg : BaseConfigTable<LevelsData>
    {
    }

    public class LevelsData : IUnique
    {
        //唯一标识
        public string Uid{ get;set;} 

        //关卡名字
        public string Name;

    }
}

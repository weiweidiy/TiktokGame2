/*
* 此类由ConfigTools自动生成. 不要手动修改!
*/
using System.Collections;
using System.Collections.Generic;
using JFramework.Game;

namespace JFramework
{
    public partial class LevelsNodesTable : BaseConfigTable<LevelsNodesCfgData>
    {
    }

    public class LevelsNodesCfgData : IUnique
    {
        //唯一标识
        public string Uid{ get;set;} 

        //关卡uid
        public string LevelUid;

        //关卡节点Uid
        public string PrefabUid;

        //关卡事件
        public string EventType;

    }
}

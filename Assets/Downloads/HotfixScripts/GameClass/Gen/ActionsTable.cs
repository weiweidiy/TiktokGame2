/*
* 此类由ConfigTools自动生成. 不要手动修改!
*/
using System.Collections;
using System.Collections.Generic;
using JFramework.Game;

namespace JFramework
{
    public partial class ActionsTable : BaseConfigTable<ActionsCfgData>
    {
    }

    public class ActionsCfgData : IUnique
    {
        //唯一标识
        public string Uid{ get;set;} 

        //名字
        public string Name;

    }
}

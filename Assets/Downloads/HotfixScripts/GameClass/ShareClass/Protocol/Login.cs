using JFramework;
using System;

namespace Tiktok
{
    /// <summary>
    /// 服务器回复消息的基础类
    /// </summary>
    public class ProtocalRes : JNetMessage
    {
        public int Code { get; set; }
    }

    public class LoginReq : JNetMessage
    {     
        public override int TypeId => (int)ProtocolType.LoginReq;
    }

    public class LoginRes : JNetMessage
    {

        public override int TypeId => (int)ProtocolType.LoginRes;

        public int Code;

        public LevelData LevelData;
    }
}


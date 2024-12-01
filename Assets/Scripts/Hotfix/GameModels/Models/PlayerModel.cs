using JFrame;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TiktokModels
{
    public struct PlayerVO
    {
        public string name;
        public string uid;
    }

    public class PlayerModel : BaseModel<List<PlayerVO>>
    {

    }

}

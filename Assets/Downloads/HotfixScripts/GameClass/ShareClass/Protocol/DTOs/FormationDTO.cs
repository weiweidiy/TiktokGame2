﻿

namespace Tiktok
{
    public class FormationDTO
    {
        public int Id { get; set; }
        public int FormationType { get; set; } // 1: 攻阵 2：防阵

        public int FormationPoint { get; set; }

        public int SamuraiId { get; set; }
    }
}
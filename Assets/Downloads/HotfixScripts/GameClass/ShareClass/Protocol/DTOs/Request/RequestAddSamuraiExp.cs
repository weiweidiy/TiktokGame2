using System.Collections.Generic;

namespace Tiktok
{
    public class RequestAddSamuraiExp
    {
        public int TargetSamuraiId { get; set; }

        public  List<int> ExpSamuraisIds { get; set; }
    }
}
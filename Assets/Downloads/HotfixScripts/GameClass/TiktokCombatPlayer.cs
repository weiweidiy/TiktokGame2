using Adic;
using JFramework;
using JFramework.Game;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

namespace Tiktok
{

    public class TiktokCombatPlayer : JCombatTurnBasedPlayer<TiktokJCombatUnitData>
    {
        [Inject]
        public TiktokCombatPlayer(JCombatTurnBasedReportData<TiktokJCombatUnitData> reportData, IJCombatAnimationPlayer animationPlayer, IObjectPool objPool = null) : base(reportData , animationPlayer, objPool)
        {
            Debug.Log("TiktokCombatPlayer Constructor " + GetHashCode());
        }
    }
}


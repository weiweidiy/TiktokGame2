using JFramework.Game;
using UnityEngine;

namespace Tiktok
{

    public class TiktokBackgroundView : MonoBehaviour
    {
        [SerializeField] Transform[] nodes;

        public Transform GetNode(int index)
        {
            if(index >= nodes.Length)
                throw new System.Exception("背景节点索引越界 " + index);
            return nodes[index];
        }
    }
}

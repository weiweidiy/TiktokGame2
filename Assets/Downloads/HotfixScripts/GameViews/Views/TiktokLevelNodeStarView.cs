using UnityEngine;

namespace Tiktok
{
    public class TiktokLevelNodeStarView : MonoBehaviour
    {
        [SerializeField] Transform[] tranStars;
        public void UpdateStars(int starCount)
        {
            for(int i = 0; i < tranStars.Length; i++)
            {
                tranStars[i].gameObject.SetActive(i < starCount);
            }

        }
    }
}

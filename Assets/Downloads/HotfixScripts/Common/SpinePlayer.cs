using Adic;
using JFramework;
using JFramework.Game;
using Spine.Unity;
using UnityEditor.VersionControl;
using UnityEngine;

namespace Tiktok
{
    public class SpinePlayer : MonoBehaviour, IAnimationPlayer
    {
        [SerializeField] SkeletonAnimation spine;

        [Inject] IAssetsLoader assetsLoader;



        private void Awake()
        {
            this.Inject();
        }

        public void FlipX()
        {
            spine.skeleton.FlipX = !spine.skeleton.FlipX;
        }

        public void Play(string animName, bool loop = true)
        {
            spine.AnimationState.SetAnimation(0, animName, loop);
        }

        public async void SetAnimation(string path, bool flipX = false)
        {
            var asset = await assetsLoader.LoadAssetAsync<SkeletonDataAsset>(path);

            spine.skeletonDataAsset = asset;
            spine.Initialize(true);
            if (flipX) FlipX();
        }

        public void Stop()
        {
            
        }
    }
}

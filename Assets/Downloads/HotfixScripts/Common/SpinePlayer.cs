using Adic;
using JFramework;
using JFramework.Game;
using Spine;
using Spine.Unity;
using System.Threading.Tasks;
using UnityEngine;

namespace Tiktok
{
    public class SpinePlayer : MonoBehaviour, IAnimationPlayer
    {
        [SerializeField] SkeletonAnimation spine;

        [Inject] IAssetsLoader assetsLoader;

        TaskCompletionSource<bool> tcs;


        private void Awake()
        {
            this.Inject();

        }

        private void OnEnable()
        {
            // 清除所有动画和状态，重置骨骼
            spine.ClearState();
            //spine.Initialize(true);
        }


        private void OnDisable()
        {
            // 反注册事件，防止内存泄漏
            if (spine != null && spine.AnimationState != null)
            {
                spine.AnimationState.Complete -= OnSpineAnimationComplete;
            }

            if (tcs != null && !tcs.Task.IsCompleted)
            {
                tcs.SetCanceled();
                tcs = null; // 清理 TaskCompletionSource
            }

            if (tcs != null)
                tcs = null;

            // 清除 Spine 动画状态
            spine.AnimationState.ClearTracks();
        }

        private void OnSpineAnimationComplete(TrackEntry trackEntry)
        {
            // trackEntry.Animation.Name 是动画名
            //Debug.Log($"Spine动画完成: {trackEntry.Animation.Name}");
            if(tcs != null && !tcs.Task.IsCompleted && trackEntry.Animation.Name == "PVP_Atk")
            {
                tcs.SetResult(true);
            }
        }

        public void FlipX()
        {
            spine.skeleton.FlipX = !spine.skeleton.FlipX;
        }

        public Task Play(string animName, bool loop = true)
        {
            if (spine == null || spine.AnimationState == null)
            {
                Debug.LogError("SpineAnimation or AnimationState is not initialized.");
                return Task.CompletedTask;
            }
            //if (tcs != null && !tcs.Task.IsCompleted)
            //{
            //    tcs.SetCanceled(); // 如果之前的任务未完成，取消它
            //}
            if(animName == "PVP_Atk")
            {
                tcs = new TaskCompletionSource<bool>();
                spine.AnimationState.SetAnimation(0, animName, loop);
                return tcs.Task;
            }

            spine.AnimationState.SetAnimation(0, animName, loop);
            return Task.CompletedTask;
        }

        public async void SetAnimation(string path, bool flipX = false)
        {
            var asset = await assetsLoader.LoadAssetAsync<SkeletonDataAsset>(path);

            spine.skeletonDataAsset = asset;
            spine.Initialize(true);
            if (flipX) FlipX();

            if (spine != null && spine.AnimationState != null)
            {
                spine.AnimationState.Complete += OnSpineAnimationComplete;
            }
        }

        public void Stop()
        {
            
        }
    }
}

// GameFrameX 组织下的以及组织衍生的项目的版权、商标、专利和其他相关权利均受相应法律法规的保护。使用本项目应遵守相关法律法规和许可证的要求。
// 
// 本项目主要遵循 MIT 许可证和 Apache 许可证（版本 2.0）进行分发和使用。许可证位于源代码树根目录中的 LICENSE 文件。
// 
// 不得利用本项目从事危害国家安全、扰乱社会秩序、侵犯他人合法权益等法律法规禁止的活动！任何基于本项目二次开发而产生的一切法律纠纷和责任，我们不承担任何责任！

using System;

namespace Spine.Unity
{
    public static class SkeletonAnimationExtension
    {
        /// <summary>
        /// 播放动画
        /// </summary>
        /// <param name="skeletonAnimation"></param>
        /// <param name="animationName">动画名称</param>
        /// <param name="loop">是否循环</param>
        /// <param name="onComplete">完成回调</param>
        public static void PlayAnimation(this SkeletonAnimation skeletonAnimation, string animationName, bool loop = false, Action onComplete = null)
        {
            void StateOnComplete(TrackEntry trackEntry)
            {
                trackEntry.Complete -= StateOnComplete;
                onComplete?.Invoke();
            }

            skeletonAnimation.state.Complete -= StateOnComplete;
            skeletonAnimation.state.Complete += StateOnComplete;
            skeletonAnimation.state.SetAnimation(0, animationName, loop);
        }

        /// <summary>
        /// 播放动画
        /// </summary>
        /// <param name="skeletonAnimation"></param>
        /// <param name="animationName">动画名称</param>
        /// <param name="trackIndex">动画轨道</param>
        /// <param name="loop">是否循环</param>
        /// <param name="onComplete">完成回调</param>
        public static void PlayAnimation(this SkeletonAnimation skeletonAnimation, string animationName, int trackIndex = 0, bool loop = false, Action onComplete = null)
        {
            void StateOnComplete(TrackEntry trackEntry)
            {
                trackEntry.Complete -= StateOnComplete;
                onComplete?.Invoke();
            }

            skeletonAnimation.state.Complete -= StateOnComplete;
            skeletonAnimation.state.Complete += StateOnComplete;
            skeletonAnimation.state.SetAnimation(trackIndex, animationName, loop);
        }
    }
}
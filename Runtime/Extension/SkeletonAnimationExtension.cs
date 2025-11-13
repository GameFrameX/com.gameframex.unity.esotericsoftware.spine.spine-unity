// GameFrameX 组织下的以及组织衍生的项目的版权、商标、专利和其他相关权利均受相应法律法规的保护。使用本项目应遵守相关法律法规和许可证的要求。
// 
// 本项目主要遵循 MIT 许可证和 Apache 许可证（版本 2.0）进行分发和使用。许可证位于源代码树根目录中的 LICENSE 文件。
// 
// 不得利用本项目从事危害国家安全、扰乱社会秩序、侵犯他人合法权益等法律法规禁止的活动！任何基于本项目二次开发而产生的一切法律纠纷和责任，我们不承担任何责任！

using System;
using UnityEngine;

namespace Spine.Unity
{
    public static class SkeletonAnimationExtension
    {
        /// <summary>
        /// 获取SkeletonAnimation的渲染排序层级
        /// </summary>
        /// <param name="skeletonAnimation">SkeletonAnimation组件</param>
        /// <returns>返回Renderer的sortingOrder；若未找到Renderer则返回默认值0</returns>
        public static int GetSortingOrder(this SkeletonAnimation skeletonAnimation)
        {
            var render = skeletonAnimation.GetComponent<Renderer>();
            if (render == null)
            {
                return default;
            }

            return render.sortingOrder;
        }

        /// <summary>
        /// 设置SkeletonAnimation的渲染排序层级
        /// </summary>
        /// <param name="skeletonAnimation">SkeletonAnimation组件</param>
        /// <param name="sortingOrder">要设置的排序层级数值</param>
        public static void SetSortingOrder(this SkeletonAnimation skeletonAnimation, int sortingOrder)
        {
            var render = skeletonAnimation.GetComponent<Renderer>();
            if (render == null)
            {
                return;
            }

            render.sortingOrder = sortingOrder;
        }


        /// <summary>
        /// 检查指定名称的动画是否存在于SkeletonAnimation组件中
        /// </summary>
        /// <param name="skeletonAnimation">SkeletonAnimation组件</param>
        /// <param name="animationName">要检查的动画名称</param>
        /// <returns>如果动画存在则返回true，否则返回false</returns>
        public static bool HasAnimation(this SkeletonAnimation skeletonAnimation, string animationName)
        {
            var skeletonData = skeletonAnimation.Skeleton.Data;
            var animation = skeletonData.FindAnimation(animationName);
            return animation != null;
        }

        /// <summary>
        /// 获取当前播放的动画名称
        /// </summary>
        /// <param name="skeletonAnimation">SkeletonAnimation组件</param>
        /// <returns>当前播放的动画名称；若未播放任何动画则返回空字符串</returns>
        public static string GetCurrentAnimationName(this SkeletonAnimation skeletonAnimation)
        {
            var currentEntry = skeletonAnimation.AnimationState.GetCurrent(0);
            return currentEntry == null ? string.Empty : currentEntry.Animation.Name;
        }

        /// <summary>
        /// 播放Spine骨骼动画
        /// </summary>
        /// <param name="skeletonAnimation">Spine骨骼动画组件</param>
        /// <param name="animationName">要播放的动画名称</param>
        /// <param name="loop">是否循环播放动画，true为循环播放，false为播放一次</param>
        /// <param name="onComplete">动画播放完成时的回调函数，仅在非循环模式下生效</param>
        public static void PlayAnimation(this SkeletonAnimation skeletonAnimation, string animationName, bool loop = false, Action onComplete = null)
        {
            PlayAnimation(skeletonAnimation, animationName, 0, loop, onComplete);
        }

        /// <summary>
        /// 在指定轨道上播放Spine骨骼动画
        /// </summary>
        /// <param name="skeletonAnimation">Spine骨骼动画组件</param>
        /// <param name="animationName">要播放的动画名称</param>
        /// <param name="trackIndex">动画轨道索引，用于混合多个动画，默认为0</param>
        /// <param name="loop">是否循环播放动画，true为循环播放，false为播放一次</param>
        /// <param name="onComplete">动画播放完成时的回调函数，仅在非循环模式下生效</param>
        public static void PlayAnimation(this SkeletonAnimation skeletonAnimation, string animationName, int trackIndex = 0, bool loop = false, Action onComplete = null)
        {
            // 定义动画完成时的回调处理函数
            void StateOnComplete(TrackEntry trackEntry)
            {
                // 移除事件监听，避免重复触发
                trackEntry.Complete -= StateOnComplete;
                // 调用用户传入的完成回调
                onComplete?.Invoke();
            }

            if (skeletonAnimation.AnimationState != null)
            {
                // 确保移除之前可能存在的完成事件监听
                skeletonAnimation.AnimationState.Complete -= StateOnComplete;
                // 非循环模式下添加完成事件监听
                if (!loop)
                {
                    skeletonAnimation.AnimationState.Complete += StateOnComplete;
                }

                // 设置并播放指定轨道上的动画
                skeletonAnimation.AnimationState.SetAnimation(trackIndex, animationName, loop);
            }
            else
            {
                Debug.LogError("AnimationState Is null");
            }
        }
    }
}
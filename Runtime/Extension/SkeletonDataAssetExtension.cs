// ==========================================================================================
//  GameFrameX 组织及其衍生项目的版权、商标、专利及其他相关权利
//  GameFrameX organization and its derivative projects' copyrights, trademarks, patents, and related rights
//  均受中华人民共和国及相关国际法律法规保护。
//  are protected by the laws of the People's Republic of China and relevant international regulations.
// 
//  使用本项目须严格遵守相应法律法规及开源许可证之规定。
//  Usage of this project must strictly comply with applicable laws, regulations, and open-source licenses.
// 
//  本项目采用 MIT 许可证与 Apache License 2.0 双许可证分发，
//  This project is dual-licensed under the MIT License and Apache License 2.0,
//  完整许可证文本请参见源代码根目录下的 LICENSE 文件。
//  please refer to the LICENSE file in the root directory of the source code for the full license text.
// 
//  禁止利用本项目实施任何危害国家安全、破坏社会秩序、
//  It is prohibited to use this project to engage in any activities that endanger national security, disrupt social order,
//  侵犯他人合法权益等法律法规所禁止的行为！
//  or infringe upon the legitimate rights and interests of others, as prohibited by laws and regulations!
//  因基于本项目二次开发所产生的一切法律纠纷与责任，
//  Any legal disputes and liabilities arising from secondary development based on this project
//  本项目组织与贡献者概不承担。
//  shall be borne solely by the developer; the project organization and contributors assume no responsibility.
// 
//  GitHub 仓库：https://github.com/GameFrameX
//  GitHub Repository: https://github.com/GameFrameX
//  Gitee  仓库：https://gitee.com/GameFrameX
//  Gitee Repository:  https://gitee.com/GameFrameX
//  官方文档：https://gameframex.doc.alianblank.com/
//  Official Documentation: https://gameframex.doc.alianblank.com/
// ==========================================================================================

using UnityEngine;

namespace Spine.Unity
{
    public static class SkeletonDataAssetExtension
    {
        /// <summary>
        /// 为 GameObject 添加或替换 SkeletonAnimation 组件，并设置骨骼数据与动画
        /// </summary>
        /// <param name="gameObject">需要挂载或更新 SkeletonAnimation 的 GameObject</param>
        /// <param name="skeletonDataAsset">骨骼数据资源</param>
        /// <param name="animationName">初始动画名称，为空则不播放动画</param>
        /// <param name="isLoop">是否循环播放</param>
        /// <param name="quiet">是否静默添加（不输出日志）</param>
        /// <returns>添加或更新后的 SkeletonAnimation 组件</returns>
        public static SkeletonAnimation AddOrReplace(this GameObject gameObject, SkeletonDataAsset skeletonDataAsset, string animationName = null, bool isLoop = false, bool quiet = false)
        {
            if (skeletonDataAsset == null)
            {
                Debug.LogError("skeletonDataAsset is null");
                return default;
            }

            // 将 GameObject 名称同步为资源名称，方便调试
            gameObject.name = skeletonDataAsset.name;
            var component = gameObject.GetComponent<SkeletonAnimation>();

            if (component == null)
            {
                // 不存在则自动添加新组件
                return SkeletonRenderer.AddSpineComponent<SkeletonAnimation>(gameObject, skeletonDataAsset, quiet);
            }

            component.ClearState();
            // 已存在则直接替换骨骼数据并刷新
            component.skeletonDataAsset = skeletonDataAsset;
            component.Initialize(true, true);
            skeletonDataAsset.GetSkeletonData(true); // 强制同步数据
            OnChangeSpine(component, animationName, isLoop);
            return component;
        }

        /// <summary>
        /// 切换 SkeletonAnimation 的动画与皮肤，并同步到初始姿态
        /// </summary>
        /// <param name="skeletonAnimation">目标 SkeletonAnimation</param>
        /// <param name="animationName">需要切换的动画名称，为空则清空轨道</param>
        /// <param name="isLoop">是否循环</param>
        public static void OnChangeSpine(this SkeletonAnimation skeletonAnimation, string animationName, bool isLoop)
        {
            var skeletonData = skeletonAnimation.Skeleton.Data;

            var state = skeletonAnimation.AnimationState;
            var animationToUse = !string.IsNullOrEmpty(animationName) ? skeletonData.FindAnimation(animationName) : null;
            if (animationToUse != null)
            {
                var trackEntry = state.GetCurrent(0);
                // 若当前无动画、动画名不同或已播放完毕且非循环，则重新设置
                if (trackEntry == null || trackEntry.Animation.Name != animationName || trackEntry.IsComplete && !trackEntry.Loop)
                {
                    trackEntry = state.SetAnimation(0, animationToUse, isLoop);
                }
                else
                {
                    // 仅更新循环状态
                    trackEntry.Loop = isLoop;
                }

                trackEntry.TimeScale = 1; // 重置播放速度
            }
            else
            {
                // 无动画时清空轨道
                state.ClearTrack(0);
            }

            // 同步皮肤：优先使用默认皮肤，否则取首个可用皮肤
            var skin = skeletonData.DefaultSkin;
            if (skin == null && skeletonData.Skins.Count > 0)
            {
                skin = skeletonData.Skins.Items[0];
            }

            if (skeletonAnimation.skeleton.Skin != skin)
            {
                skeletonAnimation.skeleton.SetSkin(skin);
                skeletonAnimation.skeleton.SetSlotsToSetupPose(); // 强制刷新到初始姿态
            }

            skeletonAnimation.LateUpdate();
        }
    }
}
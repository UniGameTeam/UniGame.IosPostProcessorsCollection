﻿#if UNITY_IOS

using System.Collections.Generic;
using UnityEditor.iOS.Xcode;

namespace PostprocessCollection
{

    /// <summary>
    /// Links core frameworks to XCode project,
    /// generated by Unity3D.
    /// 
    /// Examples of valid framework names:
    /// "SystemConfiguration",
    /// "UIKit",
    /// "Foundation",
    /// "CoreTelephony",
    /// "CoreLocation",
    /// "CoreGraphics",
    /// "AdSupport",
    /// "Security",
    /// "GameKit",
    /// "SafariServices"
    /// </summary>
    public static class AddFrameworksPostprocess //: ScriptableObject
    {
        public static void AddFrameworks(PBXProject project, string target,
            List<iOSFrameworkDescription> frameworksInfo)
        {
            if(frameworksInfo == null) return;
            foreach (var framework in frameworksInfo)
                project.AddFrameworkToProject(target, framework.Name + ".framework", framework.IsWeak);
        }

    }
}
#endif
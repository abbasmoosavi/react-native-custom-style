using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace React.Native.Custom.Style.RNReactNativeCustomStyle
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNReactNativeCustomStyleModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNReactNativeCustomStyleModule"/>.
        /// </summary>
        internal RNReactNativeCustomStyleModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNReactNativeCustomStyle";
            }
        }
    }
}

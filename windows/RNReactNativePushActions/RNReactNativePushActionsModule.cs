using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace React.Native.Push.Actions.RNReactNativePushActions
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNReactNativePushActionsModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNReactNativePushActionsModule"/>.
        /// </summary>
        internal RNReactNativePushActionsModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNReactNativePushActions";
            }
        }
    }
}

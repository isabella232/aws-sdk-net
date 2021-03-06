/*
 * Copyright 2015-2015 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using System;
using Amazon.MobileAnalytics;
using Amazon.MobileAnalytics.MobileAnalyticsManager;

namespace Amazon.MobileAnalytics.MobileAnalyticsManager.Internal
{
    
    /// <summary>
    /// Object that creates delivery policy.
    /// </summary>
    public class DeliveryPolicyFactory : IDeliveryPolicyFactory
    {
        private readonly bool IsDataNetworkAllowed;
        
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.DeliveryPolicyFactory"/> class.
        /// </summary>
        /// <param name="IsDataNetworkAllowed">If set to <c>true</c> connectivity policy will allow delivery on data network.</param>
        public DeliveryPolicyFactory (bool IsDataNetworkAllowed)
        {
            this.IsDataNetworkAllowed = IsDataNetworkAllowed;
        }
        
        /// <summary>
        /// returns a new connectivity policy.
        /// </summary>
        /// <returns>instance of <see cref="Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.IDeliveryPolicy"/>, which checks for network connectivity</returns>
        public IDeliveryPolicy NewConnectivityPolicy()
        {
            return new ConnectivityPolicy(this.IsDataNetworkAllowed);
        }
    
    }
}


/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticLoadBalancing.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.ElasticLoadBalancing.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeInstanceHealth Request Marshaller
    /// </summary>       
    public class DescribeInstanceHealthRequestMarshaller : IMarshaller<IRequest, DescribeInstanceHealthRequest>
    {
        public IRequest Marshall(DescribeInstanceHealthRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticLoadBalancing");
            request.Parameters.Add("Action", "DescribeInstanceHealth");
            request.Parameters.Add("Version", "2012-06-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetInstances())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.Instances)
                    {
                        if(publicRequestlistValue.IsSetInstanceId())
                        {
                            request.Parameters.Add("Instances" + "." + "member" + "." + publicRequestlistValueIndex + "." + "InstanceId", StringUtils.FromString(publicRequestlistValue.InstanceId));
                        }
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetLoadBalancerName())
                {
                    request.Parameters.Add("LoadBalancerName", StringUtils.FromString(publicRequest.LoadBalancerName));
                }
            }
            return request;
        }
    }
}
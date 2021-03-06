// ------------------------------------------------------------
// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT License (MIT).See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.ServiceFabric.Services.Remoting.V2
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the interface that must be implemented for providing custom serialization for the remoting request.
    /// </summary>
    public interface IServiceRemotingMessageSerializationProvider
    {
        /// <summary>
        /// Create a IServiceRemotingMessageBodyFactory used for creating remoting request and response body.
        /// </summary>
        /// <returns>A custom <see cref="IServiceRemotingMessageBodyFactory"/> that can be used for creating remoting request and response message bodies.</returns>
        IServiceRemotingMessageBodyFactory CreateMessageBodyFactory();

        /// <summary>
        /// Creates a serializer that can serialize and deserialize the remoting request message bodies for the specified service interface.
        /// </summary>
        /// <param name="serviceInterfaceType">User service interface</param>
        /// <param name="requestBodyTypes">Parameters for all the methods in the serviceInterfaceType</param>
        /// <returns>
        /// An <see cref="IServiceRemotingRequestMessageBodySerializer"/> that can serialize and deserialize
        /// the remoting request message bodies created by the custom service remoting message body factory.
        /// </returns>
        IServiceRemotingRequestMessageBodySerializer CreateRequestMessageSerializer(
            Type serviceInterfaceType,
            IEnumerable<Type> requestBodyTypes);

        /// <summary>
        /// Creates a serializer that can serialize and deserialize the remoting response message bodies for the specified service interface.
        /// </summary>
        /// <param name="serviceInterfaceType">User service interface</param>
        /// <param name="responseBodyTypes">Return Types for all the methods in the serviceInterfaceType</param>
        /// <returns>
        /// An <see cref="IServiceRemotingResponseMessageBodySerializer"/> that can serialize and deserialize
        /// the remoting response message bodies created by the custom service remoting message body factory.
        /// </returns>
        IServiceRemotingResponseMessageBodySerializer CreateResponseMessageSerializer(
            Type serviceInterfaceType,
            IEnumerable<Type> responseBodyTypes);
    }
}

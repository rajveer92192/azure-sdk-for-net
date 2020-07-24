// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core;

namespace Azure.Iot.Hub.Service.Authentication
{
    /// <summary>
    /// The IoT Hub credentials, to be used for authenticating against an IoT Hub instance via SAS tokens.
    /// </summary>
    public class IotHubSasCredential
    {
        private const string HostNameIdentifier = "HostName";
        private const string SharedAccessKeyIdentifier = "SharedAccessKey";
        private const string SharedAccessKeyNameIdentifier = "SharedAccessKeyName";

        internal IotHubSasCredential(string connectionString)
        {
            var iotHubConnectionString = ConnectionString.Parse(connectionString);

            SharedAccessPolicy = iotHubConnectionString.GetRequired(SharedAccessKeyNameIdentifier);
            SharedAccessKey = iotHubConnectionString.GetRequired(SharedAccessKeyIdentifier);

            Endpoint = BuildEndpointUriFromHostName(iotHubConnectionString.GetRequired(HostNameIdentifier));
        }

        /// <summary>
        /// Initializes a new instance of <see cref="IotHubSasCredential"/> class.
        /// </summary>
        /// <param name="sharedAccessPolicy">
        /// The IoT Hub access permission, which can be either "iothubowner", "service", "registryRead" or "registryReadWrite" policy, as applicable.
        /// For more information, see <see href="https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-security#access-control-and-permissions"/>.
        /// </param>
        /// <param name="sharedAccessKey">
        /// The IoT Hub shared access key associated with the shared access policy permissions.
        /// </param>
        /// <param name="timeToLive">
        /// The validity duration of the generated shared access signature token used for authentication.
        /// The token will be renewed when at 15% or less of it's lifespan. The default value is 30 minutes.
        /// </param>
        public IotHubSasCredential(string sharedAccessPolicy, string sharedAccessKey, TimeSpan? timeToLive = default)
        {
            SharedAccessPolicy = sharedAccessPolicy;
            SharedAccessKey = sharedAccessKey;

            if (timeToLive != null)
            {
                SasTokenTimeToLive = (TimeSpan)timeToLive;
            }
        }

        /// <summary>
        /// The IoT Hub service instance endpoint to connect to.
        /// </summary>
        internal Uri Endpoint { get; }

        /// <summary>
        /// The IoT Hub access permission, which can be either "iothubowner", "service", "registryRead" or "registryReadWrite" policy, as applicable.
        /// For more information, see <see href="https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-security#access-control-and-permissions"/>.
        /// </summary>
        public string SharedAccessPolicy { get; }

        /// <summary>
        /// The IoT Hub shared access key associated with the shared access policy permissions.
        /// </summary>
        public string SharedAccessKey { get; }

        /// <summary>
        /// The validity duration of the generated shared access signature token used for authentication.
        /// The token will be renewed when at 15% or less of it's lifespan. The default value is 30 minutes.
        /// </summary>
        public TimeSpan SasTokenTimeToLive { get; } = TimeSpan.FromMinutes(30);

        private static Uri BuildEndpointUriFromHostName(string hostName)
        {
            return new UriBuilder
            {
                Scheme = Uri.UriSchemeHttps,
                Host = hostName
            }.Uri;
        }
    }
}

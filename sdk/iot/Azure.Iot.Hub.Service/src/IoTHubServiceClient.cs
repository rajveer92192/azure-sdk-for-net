// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Iot.Hub.Service.Authentication;

namespace Azure.Iot.Hub.Service
{
    /// <summary>
    /// The IoT Hub Service Client.
    /// </summary>
    public class IotHubServiceClient
    {
        private readonly HttpPipeline _httpPipeline;
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly RegistryManagerRestClient _registryManagerRestClient;
        private readonly TwinRestClient _twinRestClient;
        private readonly DeviceMethodRestClient _deviceMethodRestClient;

        /// <summary>
        /// place holder for Devices
        /// </summary>
        public virtual DevicesClient Devices { get; private set; }

        /// <summary>
        /// place holder for Modules
        /// </summary>
        public virtual ModulesClient Modules { get; private set; }

        /// <summary>
        /// place holder for Statistics
        /// </summary>
        public virtual StatisticsClient Statistics { get; private set; }

        /// <summary>
        /// place holder for Messages
        /// </summary>
        public virtual CloudToDeviceMessagesClient Messages { get; private set; }

        /// <summary>
        /// place holder for Files
        /// </summary>
        public virtual FilesClient Files { get; private set; }

        /// <summary>
        /// place holder for Jobs
        /// </summary>
        public virtual JobsClient Jobs { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="IotHubServiceClient"/> class.
        /// </summary>
        protected IotHubServiceClient()
        {
            // This constructor only exists for mocking purposes in unit tests. It should not be used otherwise.
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IotHubServiceClient"/> class.
        /// </summary>
        /// <param name="connectionString">
        /// The IoT Hub connection string, with either "iothubowner", "service", "registryRead" or "registryReadWrite" policy, as applicable.
        /// For more information, see <see href="https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-security#access-control-and-permissions"/>.
        /// </param>
        public IotHubServiceClient(string connectionString)
            : this(connectionString, new IotHubServiceClientOptions())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IotHubServiceClient"/> class.
        /// </summary>
        /// <param name="connectionString">
        /// The IoT Hub connection string, with either "iothubowner", "service", "registryRead" or "registryReadWrite" policy, as applicable.
        /// For more information, see <see href="https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-security#access-control-and-permissions"/>.
        /// </param>
        /// <param name="options">
        /// Options that allow configuration of requests sent to the IoT Hub service.
        /// </param>
        public IotHubServiceClient(string connectionString, IotHubServiceClientOptions options)
        {
            Argument.AssertNotNull(options, nameof(options));

            var credential = new IotHubSasCredential(connectionString);
            var sasTokenProvider = new SasTokenProviderWithSharedAccessKey(
                credential.Endpoint,
                credential.SharedAccessPolicy,
                credential.SharedAccessKey,
                credential.SasTokenTimeToLive);

            _clientDiagnostics = new ClientDiagnostics(options);

            options.AddPolicy(new SasTokenAuthenticationPolicy(sasTokenProvider), HttpPipelinePosition.PerCall);
            _httpPipeline = HttpPipelineBuilder.Build(options);

            _registryManagerRestClient = new RegistryManagerRestClient(_clientDiagnostics, _httpPipeline, credential.Endpoint, options.GetVersionString());
            _twinRestClient = new TwinRestClient(_clientDiagnostics, _httpPipeline, null, options.GetVersionString());
            _deviceMethodRestClient = new DeviceMethodRestClient(_clientDiagnostics, _httpPipeline, credential.Endpoint, options.GetVersionString());

            Devices = new DevicesClient(_registryManagerRestClient, _twinRestClient, _deviceMethodRestClient);
            Modules = new ModulesClient(_registryManagerRestClient, _twinRestClient, _deviceMethodRestClient);

            Statistics = new StatisticsClient();
            Messages = new CloudToDeviceMessagesClient();
            Files = new FilesClient();
            Jobs = new JobsClient();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IotHubServiceClient"/> class.
        /// </summary>
        /// <param name="endpoint">
        /// The IoT Hub service instance endpoint to connect to.
        /// </param>
        /// <param name="credential">
        /// The IoT Hub credentials, to be used for authenticating against an IoT Hub instance via SAS tokens.
        /// </param>
        /// <param name="options">
        /// Options that allow configuration of requests sent to the IoT Hub service.
        /// </param>
        public IotHubServiceClient(Uri endpoint, IotHubSasCredential credential, IotHubServiceClientOptions options = default)
        {
            options ??= new IotHubServiceClientOptions();

            var sasTokenProvider = new SasTokenProviderWithSharedAccessKey(
                endpoint,
                credential.SharedAccessPolicy,
                credential.SharedAccessKey,
                credential.SasTokenTimeToLive);

            _clientDiagnostics = new ClientDiagnostics(options);

            options.AddPolicy(new SasTokenAuthenticationPolicy(sasTokenProvider), HttpPipelinePosition.PerCall);
            _httpPipeline = HttpPipelineBuilder.Build(options);

            _registryManagerRestClient = new RegistryManagerRestClient(_clientDiagnostics, _httpPipeline, endpoint, options.GetVersionString());
            _twinRestClient = new TwinRestClient(_clientDiagnostics, _httpPipeline, null, options.GetVersionString());
            _deviceMethodRestClient = new DeviceMethodRestClient(_clientDiagnostics, _httpPipeline, endpoint, options.GetVersionString());

            Devices = new DevicesClient(_registryManagerRestClient, _twinRestClient, _deviceMethodRestClient);
            Modules = new ModulesClient(_registryManagerRestClient, _twinRestClient, _deviceMethodRestClient);

            Statistics = new StatisticsClient();
            Messages = new CloudToDeviceMessagesClient();
            Files = new FilesClient();
            Jobs = new JobsClient();
        }

        // TODO: Will be enabled once service starts supporting OAuth tokens, for authentication - added here only for reference
        /// <summary>
        /// Initializes a new instance of the <see cref="IotHubServiceClient"/> class.
        /// </summary>
        /// <param name="endpoint">
        /// The IoT Hub service instance endpoint to connect to.
        /// </param>
        /// <param name="credential">
        /// The <see cref="TokenCredential"/> implementation which will be used to request for the authentication token.
        /// </param>
        /// <param name="options">
        /// Options that allow configuration of requests sent to the IoT Hub service.
        /// </param>
        public IotHubServiceClient(Uri endpoint, TokenCredential credential, IotHubServiceClientOptions options = default)
        {
            options ??= new IotHubServiceClientOptions();

            _clientDiagnostics = new ClientDiagnostics(options);

            options.AddPolicy(new BearerTokenAuthenticationPolicy(credential, "token_credential_scope_here"), HttpPipelinePosition.PerCall);
            _httpPipeline = HttpPipelineBuilder.Build(options);

            _registryManagerRestClient = new RegistryManagerRestClient(_clientDiagnostics, _httpPipeline, endpoint, options.GetVersionString());
            _twinRestClient = new TwinRestClient(_clientDiagnostics, _httpPipeline, null, options.GetVersionString());
            _deviceMethodRestClient = new DeviceMethodRestClient(_clientDiagnostics, _httpPipeline, endpoint, options.GetVersionString());

            Devices = new DevicesClient(_registryManagerRestClient, _twinRestClient, _deviceMethodRestClient);
            Modules = new ModulesClient(_registryManagerRestClient, _twinRestClient, _deviceMethodRestClient);

            Statistics = new StatisticsClient();
            Messages = new CloudToDeviceMessagesClient();
            Files = new FilesClient();
            Jobs = new JobsClient();
        }
    }
}

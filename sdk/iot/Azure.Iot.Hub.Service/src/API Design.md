# Azure Iot Hub Service API Design Doc

This document outlines the APIs for the Azure Iot Hub Service SDK

<details><summary><b>Type definition names</b></summary>

```text
Configuration - TwinConfiguration
Module - ModuleIdentity
Device - DeviceIdentity
Twin - TwinData
Interface - PnpInterface
Property - PnpProperty
Reported - PnpReported
Desired - PnpDesired
```

</details>

<details><summary><b>Constructors</b></summary>


Usage:

We start off with a string connection string, that we can copy from Azure portal.

```csharp
string connectionString = "HostName=<hub_hostname>.azure-devices.net;SharedAccessKeyName=<shared_access_policy>;SharedAccessKey=<shared_access_key>";
```

The client can now be initialized using:
Option 1:

```csharp
var client = new IoTHubServiceClient(connectionString);
```

Option 2:

```csharp
var endpoint = new Uri("http:<hub_hostname>.azure-devices.net");
var credential = new IotHubSasCredential("shared_access_policy", "shared_access_key");
var client = new IoTHubServiceClient(endpoint, credential);
```

```csharp
/// <summary>
/// Initializes a new instance of the <see cref="IoTHubServiceClient"/> class.
/// </summary>
/// <param name="connectionString">
/// The IoT Hub connection string, with either "iothubowner", "service", "registryRead" or "registryReadWrite" policy, as applicable.
/// For more information, see <see href="https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-security#access-control-and-permissions"/>.
/// </param>
public IoTHubServiceClient(string connectionString) {}

/// <summary>
/// Initializes a new instance of the <see cref="IoTHubServiceClient"/> class.
/// </summary>
/// <param name="connectionString">
/// The IoT Hub connection string, with either "iothubowner", "service", "registryRead" or "registryReadWrite" policy, as applicable.
/// For more information, see <see href="https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-security#access-control-and-permissions"/>.
/// </param>
/// <param name="options">
/// Options that allow configuration of requests sent to the IoT Hub service.
/// </param>
public IoTHubServiceClient(string connectionString, IoTHubServiceClientOptions options) {}

/// <summary>
/// Initializes a new instance of the <see cref="IoTHubServiceClient"/> class.
/// </summary>
/// <param name="endpoint">
/// The IoT Hub service instance endpoint to connect to.
/// </param>
/// <param name="credential">
/// The IoT Hub credentials, to be used for authenticating against an IoT Hub instance via SAS tokens.
/// </param>
public IoTHubServiceClient(Uri endpoint, IotHubSasCredential credential) {}

/// <summary>
/// Initializes a new instance of the <see cref="IoTHubServiceClient"/> class.
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
public IoTHubServiceClient(Uri endpoint, IotHubSasCredential credential, IoTHubServiceClientOptions options) {}

// TODO: Will be added once service implement's OAuth support

/// <summary>
/// Initializes a new instance of the <see cref="IoTHubServiceClient"/> class.
/// </summary>
/// <param name="endpoint">
/// The IoT Hub service instance endpoint to connect to.
/// </param>
/// <param name="credential">
/// The <see cref="TokenCredential"/> implementation which will be used to request for the authentication token.
///</param>
public IoTHubServiceClient(Uri endpoint, TokenCredential credential) {}

/// <summary>
/// Initializes a new instance of the <see cref="IoTHubServiceClient"/> class.
/// </summary>
/// <param name="endpoint">
/// The IoT Hub service instance endpoint to connect to.
/// </param>
/// <param name="credential">
/// The <see cref="TokenCredential"/> implementation which will be used to request for the authentication token.
///</param>
/// <param name="options">
/// Options that allow configuration of requests sent to the IoT Hub service.
/// </param>
public IoTHubServiceClient(Uri endpoint, TokenCredential credential, IoTHubServiceClientOptions options) {}

```

</details>

<details><summary><b>Configurations</b></summary>

APIs for managing configurations for devices and modules

```csharp

```

</details>

<details><summary><b>Statistics</b></summary>

APIs for getting statistics about devices and modules, as well as service statistics

```csharp

```

</details>

<details><summary><b>Devices</b></summary>
APIs for managing device identities, device twins, and querying devices

This sub-client has been implemented. Refer to [DevicesClient](./DevicesClient.cs).

</details>

<details><summary><b>Modules</b></summary>

APIs for managing module identities, module twins, and querying modules

This sub-client has been implemented. Refer to [ModulesClient](./ModulesClient.cs).

</details>

<details><summary><b>Jobs</b></summary>
APIs for using IotHub v2 jobs

```csharp

```

</details>

<details><summary><b>Messages</b></summary>
Feedback messages, sending cloud to device messages (missing from current swagger), and purging cloud to device message queue
```csharp
```
</details>

<details><summary><b>Files</b></summary>
APIs for getting file upload notifications (missing from current swagger)

```csharp
```

</details>

<details><summary><b>Fault Injection</b></summary>
Not sure if we'll expose these

```csharp
```

</details>

<details><summary><b>Query</b></summary>
APIs for querying on device or module identities

```csharp
```

</details>

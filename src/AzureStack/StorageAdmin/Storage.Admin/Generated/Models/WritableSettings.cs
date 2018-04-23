// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Storage.Admin.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Storage service settings.
    /// </summary>
    public partial class WritableSettings
    {
        /// <summary>
        /// Initializes a new instance of the WritableSettings class.
        /// </summary>
        public WritableSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WritableSettings class.
        /// </summary>
        /// <param name="frontEndCallbackThreadsCount">Front end callback
        /// threads count.</param>
        /// <param name="frontEndCpuBasedKeepAliveThrottlingEnabled">Switch of
        /// front end CPU based keep-alive throttling.</param>
        /// <param
        /// name="frontEndCpuBasedKeepAliveThrottlingPercentCpuThreshold">Threshold
        /// (% percentage) of front end CPU based keep-alive
        /// throttling.</param>
        /// <param
        /// name="frontEndCpuBasedKeepAliveThrottlingPercentRequestsToThrottle">Threshold
        /// (% percentage) of requests to throttle in front end CPU based
        /// keep-alive throttling.</param>
        /// <param
        /// name="frontEndCpuBasedKeepAliveThrottlingCpuMonitorIntervalInSeconds">Interval
        /// (in second) of CPU monitor for front end CPU based keep-alive
        /// throttling.</param>
        /// <param name="frontEndMemoryThrottlingEnabled">Switch of front end
        /// memory throttling.</param>
        /// <param name="frontEndMaxMillisecondsBetweenMemorySamples">Maxium
        /// interval (in millisecond) between memory samples of front
        /// end.</param>
        /// <param name="frontEndMemoryThrottleThresholdSettings">Front end
        /// memory throttle threshold settings.</param>
        /// <param name="frontEndMinThreadPoolThreads">Front end minimum number
        /// of threads in thread pool.</param>
        /// <param
        /// name="frontEndThreadPoolBasedKeepAliveIOCompletionThreshold">Threshold
        /// of front end thread pool based keep-alive IO completion.</param>
        /// <param
        /// name="frontEndThreadPoolBasedKeepAliveWorkerThreadThreshold">Threshold
        /// of front end thread pool based keep-alive worker thread.</param>
        /// <param
        /// name="frontEndThreadPoolBasedKeepAliveMonitorIntervalInSeconds">Monitor
        /// interval (in seconds) of front end thread pool based keep-alive
        /// monitor.</param>
        /// <param name="frontEndThreadPoolBasedKeepAlivePercentage">Percentage
        /// (%) of front end thread pool based keep-alive.</param>
        /// <param name="frontEndUseSlaTimeInAvailability">Switch of whether
        /// front end uses SLA time in availability.</param>
        public WritableSettings(int? frontEndCallbackThreadsCount = default(int?), bool? frontEndCpuBasedKeepAliveThrottlingEnabled = default(bool?), double? frontEndCpuBasedKeepAliveThrottlingPercentCpuThreshold = default(double?), double? frontEndCpuBasedKeepAliveThrottlingPercentRequestsToThrottle = default(double?), int? frontEndCpuBasedKeepAliveThrottlingCpuMonitorIntervalInSeconds = default(int?), bool? frontEndMemoryThrottlingEnabled = default(bool?), int? frontEndMaxMillisecondsBetweenMemorySamples = default(int?), string frontEndMemoryThrottleThresholdSettings = default(string), int? frontEndMinThreadPoolThreads = default(int?), int? frontEndThreadPoolBasedKeepAliveIOCompletionThreshold = default(int?), int? frontEndThreadPoolBasedKeepAliveWorkerThreadThreshold = default(int?), int? frontEndThreadPoolBasedKeepAliveMonitorIntervalInSeconds = default(int?), double? frontEndThreadPoolBasedKeepAlivePercentage = default(double?), bool? frontEndUseSlaTimeInAvailability = default(bool?))
        {
            FrontEndCallbackThreadsCount = frontEndCallbackThreadsCount;
            FrontEndCpuBasedKeepAliveThrottlingEnabled = frontEndCpuBasedKeepAliveThrottlingEnabled;
            FrontEndCpuBasedKeepAliveThrottlingPercentCpuThreshold = frontEndCpuBasedKeepAliveThrottlingPercentCpuThreshold;
            FrontEndCpuBasedKeepAliveThrottlingPercentRequestsToThrottle = frontEndCpuBasedKeepAliveThrottlingPercentRequestsToThrottle;
            FrontEndCpuBasedKeepAliveThrottlingCpuMonitorIntervalInSeconds = frontEndCpuBasedKeepAliveThrottlingCpuMonitorIntervalInSeconds;
            FrontEndMemoryThrottlingEnabled = frontEndMemoryThrottlingEnabled;
            FrontEndMaxMillisecondsBetweenMemorySamples = frontEndMaxMillisecondsBetweenMemorySamples;
            FrontEndMemoryThrottleThresholdSettings = frontEndMemoryThrottleThresholdSettings;
            FrontEndMinThreadPoolThreads = frontEndMinThreadPoolThreads;
            FrontEndThreadPoolBasedKeepAliveIOCompletionThreshold = frontEndThreadPoolBasedKeepAliveIOCompletionThreshold;
            FrontEndThreadPoolBasedKeepAliveWorkerThreadThreshold = frontEndThreadPoolBasedKeepAliveWorkerThreadThreshold;
            FrontEndThreadPoolBasedKeepAliveMonitorIntervalInSeconds = frontEndThreadPoolBasedKeepAliveMonitorIntervalInSeconds;
            FrontEndThreadPoolBasedKeepAlivePercentage = frontEndThreadPoolBasedKeepAlivePercentage;
            FrontEndUseSlaTimeInAvailability = frontEndUseSlaTimeInAvailability;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets front end callback threads count.
        /// </summary>
        [JsonProperty(PropertyName = "frontEndCallbackThreadsCount")]
        public int? FrontEndCallbackThreadsCount { get; set; }

        /// <summary>
        /// Gets or sets switch of front end CPU based keep-alive throttling.
        /// </summary>
        [JsonProperty(PropertyName = "frontEndCpuBasedKeepAliveThrottlingEnabled")]
        public bool? FrontEndCpuBasedKeepAliveThrottlingEnabled { get; set; }

        /// <summary>
        /// Gets or sets threshold (% percentage) of front end CPU based
        /// keep-alive throttling.
        /// </summary>
        [JsonProperty(PropertyName = "frontEndCpuBasedKeepAliveThrottlingPercentCpuThreshold")]
        public double? FrontEndCpuBasedKeepAliveThrottlingPercentCpuThreshold { get; set; }

        /// <summary>
        /// Gets or sets threshold (% percentage) of requests to throttle in
        /// front end CPU based keep-alive throttling.
        /// </summary>
        [JsonProperty(PropertyName = "frontEndCpuBasedKeepAliveThrottlingPercentRequestsToThrottle")]
        public double? FrontEndCpuBasedKeepAliveThrottlingPercentRequestsToThrottle { get; set; }

        /// <summary>
        /// Gets or sets interval (in second) of CPU monitor for front end CPU
        /// based keep-alive throttling.
        /// </summary>
        [JsonProperty(PropertyName = "frontEndCpuBasedKeepAliveThrottlingCpuMonitorIntervalInSeconds")]
        public int? FrontEndCpuBasedKeepAliveThrottlingCpuMonitorIntervalInSeconds { get; set; }

        /// <summary>
        /// Gets or sets switch of front end memory throttling.
        /// </summary>
        [JsonProperty(PropertyName = "frontEndMemoryThrottlingEnabled")]
        public bool? FrontEndMemoryThrottlingEnabled { get; set; }

        /// <summary>
        /// Gets or sets maxium interval (in millisecond) between memory
        /// samples of front end.
        /// </summary>
        [JsonProperty(PropertyName = "frontEndMaxMillisecondsBetweenMemorySamples")]
        public int? FrontEndMaxMillisecondsBetweenMemorySamples { get; set; }

        /// <summary>
        /// Gets or sets front end memory throttle threshold settings.
        /// </summary>
        [JsonProperty(PropertyName = "frontEndMemoryThrottleThresholdSettings")]
        public string FrontEndMemoryThrottleThresholdSettings { get; set; }

        /// <summary>
        /// Gets or sets front end minimum number of threads in thread pool.
        /// </summary>
        [JsonProperty(PropertyName = "frontEndMinThreadPoolThreads")]
        public int? FrontEndMinThreadPoolThreads { get; set; }

        /// <summary>
        /// Gets or sets threshold of front end thread pool based keep-alive IO
        /// completion.
        /// </summary>
        [JsonProperty(PropertyName = "frontEndThreadPoolBasedKeepAliveIOCompletionThreshold")]
        public int? FrontEndThreadPoolBasedKeepAliveIOCompletionThreshold { get; set; }

        /// <summary>
        /// Gets or sets threshold of front end thread pool based keep-alive
        /// worker thread.
        /// </summary>
        [JsonProperty(PropertyName = "frontEndThreadPoolBasedKeepAliveWorkerThreadThreshold")]
        public int? FrontEndThreadPoolBasedKeepAliveWorkerThreadThreshold { get; set; }

        /// <summary>
        /// Gets or sets monitor interval (in seconds) of front end thread pool
        /// based keep-alive monitor.
        /// </summary>
        [JsonProperty(PropertyName = "frontEndThreadPoolBasedKeepAliveMonitorIntervalInSeconds")]
        public int? FrontEndThreadPoolBasedKeepAliveMonitorIntervalInSeconds { get; set; }

        /// <summary>
        /// Gets or sets percentage (%) of front end thread pool based
        /// keep-alive.
        /// </summary>
        [JsonProperty(PropertyName = "frontEndThreadPoolBasedKeepAlivePercentage")]
        public double? FrontEndThreadPoolBasedKeepAlivePercentage { get; set; }

        /// <summary>
        /// Gets or sets switch of whether front end uses SLA time in
        /// availability.
        /// </summary>
        [JsonProperty(PropertyName = "frontEndUseSlaTimeInAvailability")]
        public bool? FrontEndUseSlaTimeInAvailability { get; set; }

    }
}

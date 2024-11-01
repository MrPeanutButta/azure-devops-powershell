// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Details of the gateway operation.</summary>
    public partial class GatewayOperationDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IGatewayOperationDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IGatewayOperationDetailsInternal
    {

        /// <summary>Backing field for <see cref="DataStore" /> property.</summary>
        private string[] _dataStore;

        /// <summary>A value indicating the datastore collection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string[] DataStore { get => this._dataStore; }

        /// <summary>Backing field for <see cref="HostName" /> property.</summary>
        private string _hostName;

        /// <summary>A value indicating the ESXi host name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string HostName { get => this._hostName; }

        /// <summary>Internal Acessors for DataStore</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IGatewayOperationDetailsInternal.DataStore { get => this._dataStore; set { {_dataStore = value;} } }

        /// <summary>Internal Acessors for HostName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IGatewayOperationDetailsInternal.HostName { get => this._hostName; set { {_hostName = value;} } }

        /// <summary>Internal Acessors for ProgressPercentage</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IGatewayOperationDetailsInternal.ProgressPercentage { get => this._progressPercentage; set { {_progressPercentage = value;} } }

        /// <summary>Internal Acessors for State</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IGatewayOperationDetailsInternal.State { get => this._state; set { {_state = value;} } }

        /// <summary>Internal Acessors for TimeElapsed</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IGatewayOperationDetailsInternal.TimeElapsed { get => this._timeElapsed; set { {_timeElapsed = value;} } }

        /// <summary>Internal Acessors for TimeRemaining</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IGatewayOperationDetailsInternal.TimeRemaining { get => this._timeRemaining; set { {_timeRemaining = value;} } }

        /// <summary>Internal Acessors for UploadSpeed</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IGatewayOperationDetailsInternal.UploadSpeed { get => this._uploadSpeed; set { {_uploadSpeed = value;} } }

        /// <summary>Internal Acessors for VmwareReadThroughput</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IGatewayOperationDetailsInternal.VmwareReadThroughput { get => this._vmwareReadThroughput; set { {_vmwareReadThroughput = value;} } }

        /// <summary>Backing field for <see cref="ProgressPercentage" /> property.</summary>
        private int? _progressPercentage;

        /// <summary>A value indicating the progress percentage of gateway operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public int? ProgressPercentage { get => this._progressPercentage; }

        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private string _state;

        /// <summary>A value indicating the state of gateway operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string State { get => this._state; }

        /// <summary>Backing field for <see cref="TimeElapsed" /> property.</summary>
        private long? _timeElapsed;

        /// <summary>A value indicating the time elapsed for the operation in milliseconds.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public long? TimeElapsed { get => this._timeElapsed; }

        /// <summary>Backing field for <see cref="TimeRemaining" /> property.</summary>
        private long? _timeRemaining;

        /// <summary>A value indicating the time remaining for the operation in milliseconds.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public long? TimeRemaining { get => this._timeRemaining; }

        /// <summary>Backing field for <see cref="UploadSpeed" /> property.</summary>
        private long? _uploadSpeed;

        /// <summary>A value indicating the upload speed in bytes per second.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public long? UploadSpeed { get => this._uploadSpeed; }

        /// <summary>Backing field for <see cref="VmwareReadThroughput" /> property.</summary>
        private long? _vmwareReadThroughput;

        /// <summary>A value indicating the VMware read throughput in bytes per second.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public long? VmwareReadThroughput { get => this._vmwareReadThroughput; }

        /// <summary>Creates an new <see cref="GatewayOperationDetails" /> instance.</summary>
        public GatewayOperationDetails()
        {

        }
    }
    /// Details of the gateway operation.
    public partial interface IGatewayOperationDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>A value indicating the datastore collection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A value indicating the datastore collection.",
        SerializedName = @"dataStores",
        PossibleTypes = new [] { typeof(string) })]
        string[] DataStore { get;  }
        /// <summary>A value indicating the ESXi host name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A value indicating the ESXi host name.",
        SerializedName = @"hostName",
        PossibleTypes = new [] { typeof(string) })]
        string HostName { get;  }
        /// <summary>A value indicating the progress percentage of gateway operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A value indicating the progress percentage of gateway operation.",
        SerializedName = @"progressPercentage",
        PossibleTypes = new [] { typeof(int) })]
        int? ProgressPercentage { get;  }
        /// <summary>A value indicating the state of gateway operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A value indicating the state of gateway operation.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        string State { get;  }
        /// <summary>A value indicating the time elapsed for the operation in milliseconds.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A value indicating the time elapsed for the operation in milliseconds.",
        SerializedName = @"timeElapsed",
        PossibleTypes = new [] { typeof(long) })]
        long? TimeElapsed { get;  }
        /// <summary>A value indicating the time remaining for the operation in milliseconds.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A value indicating the time remaining for the operation in milliseconds.",
        SerializedName = @"timeRemaining",
        PossibleTypes = new [] { typeof(long) })]
        long? TimeRemaining { get;  }
        /// <summary>A value indicating the upload speed in bytes per second.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A value indicating the upload speed in bytes per second.",
        SerializedName = @"uploadSpeed",
        PossibleTypes = new [] { typeof(long) })]
        long? UploadSpeed { get;  }
        /// <summary>A value indicating the VMware read throughput in bytes per second.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A value indicating the VMware read throughput in bytes per second.",
        SerializedName = @"vmwareReadThroughput",
        PossibleTypes = new [] { typeof(long) })]
        long? VmwareReadThroughput { get;  }

    }
    /// Details of the gateway operation.
    internal partial interface IGatewayOperationDetailsInternal

    {
        /// <summary>A value indicating the datastore collection.</summary>
        string[] DataStore { get; set; }
        /// <summary>A value indicating the ESXi host name.</summary>
        string HostName { get; set; }
        /// <summary>A value indicating the progress percentage of gateway operation.</summary>
        int? ProgressPercentage { get; set; }
        /// <summary>A value indicating the state of gateway operation.</summary>
        string State { get; set; }
        /// <summary>A value indicating the time elapsed for the operation in milliseconds.</summary>
        long? TimeElapsed { get; set; }
        /// <summary>A value indicating the time remaining for the operation in milliseconds.</summary>
        long? TimeRemaining { get; set; }
        /// <summary>A value indicating the upload speed in bytes per second.</summary>
        long? UploadSpeed { get; set; }
        /// <summary>A value indicating the VMware read throughput in bytes per second.</summary>
        long? VmwareReadThroughput { get; set; }

    }
}
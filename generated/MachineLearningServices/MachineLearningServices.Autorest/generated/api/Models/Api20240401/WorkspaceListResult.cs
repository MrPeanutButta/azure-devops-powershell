// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// <summary>The result of a request to list machine learning workspaces.</summary>
    public partial class WorkspaceListResult :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IWorkspaceListResult,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IWorkspaceListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>
        /// The URI that can be used to request the next list of machine learning workspaces.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IWorkspace[] _value;

        /// <summary>
        /// The list of machine learning workspaces. Since this list may be incomplete, the nextLink field should be used to request
        /// the next list of machine learning workspaces.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IWorkspace[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="WorkspaceListResult" /> instance.</summary>
        public WorkspaceListResult()
        {

        }
    }
    /// The result of a request to list machine learning workspaces.
    public partial interface IWorkspaceListResult :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The URI that can be used to request the next list of machine learning workspaces.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The URI that can be used to request the next list of machine learning workspaces.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>
        /// The list of machine learning workspaces. Since this list may be incomplete, the nextLink field should be used to request
        /// the next list of machine learning workspaces.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of machine learning workspaces. Since this list may be incomplete, the nextLink field should be used to request the next list of machine learning workspaces.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IWorkspace) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IWorkspace[] Value { get; set; }

    }
    /// The result of a request to list machine learning workspaces.
    internal partial interface IWorkspaceListResultInternal

    {
        /// <summary>
        /// The URI that can be used to request the next list of machine learning workspaces.
        /// </summary>
        string NextLink { get; set; }
        /// <summary>
        /// The list of machine learning workspaces. Since this list may be incomplete, the nextLink field should be used to request
        /// the next list of machine learning workspaces.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IWorkspace[] Value { get; set; }

    }
}
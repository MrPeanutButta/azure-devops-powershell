// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Alb.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Alb.Runtime.Extensions;

    /// <summary>The response of a Association list operation.</summary>
    public partial class AssociationListResult :
        Microsoft.Azure.PowerShell.Cmdlets.Alb.Models.IAssociationListResult,
        Microsoft.Azure.PowerShell.Cmdlets.Alb.Models.IAssociationListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Alb.Origin(Microsoft.Azure.PowerShell.Cmdlets.Alb.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Alb.Models.IAssociation> _value;

        /// <summary>The Association items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Alb.Origin(Microsoft.Azure.PowerShell.Cmdlets.Alb.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Alb.Models.IAssociation> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="AssociationListResult" /> instance.</summary>
        public AssociationListResult()
        {

        }
    }
    /// The response of a Association list operation.
    public partial interface IAssociationListResult :
        Microsoft.Azure.PowerShell.Cmdlets.Alb.Runtime.IJsonSerializable
    {
        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Alb.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The link to the next page of items",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The Association items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Alb.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The Association items on this page",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Alb.Models.IAssociation) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Alb.Models.IAssociation> Value { get; set; }

    }
    /// The response of a Association list operation.
    internal partial interface IAssociationListResultInternal

    {
        /// <summary>The link to the next page of items</summary>
        string NextLink { get; set; }
        /// <summary>The Association items on this page</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Alb.Models.IAssociation> Value { get; set; }

    }
}
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Extensions;

    /// <summary>Class representing a database script.</summary>
    public partial class Script :
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScript,
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.Resource();

        /// <summary>
        /// The script content. This property should be used when the script is provide inline and not through file in a SA. Must
        /// not be used together with scriptUrl and scriptUrlSasToken properties.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inlined)]
        public string Content { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptPropertiesInternal)Property).ScriptContent; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptPropertiesInternal)Property).ScriptContent = value ?? null; }

        /// <summary>Flag that indicates whether to continue if one of the command fails.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inlined)]
        public bool? ContinueOnError { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptPropertiesInternal)Property).ContinueOnError; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptPropertiesInternal)Property).ContinueOnError = value ?? default(bool); }

        /// <summary>A unique string. If changed the script will be applied again.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inlined)]
        public string ForceUpdateTag { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptPropertiesInternal)Property).ForceUpdateTag; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptPropertiesInternal)Property).ForceUpdateTag = value ?? null; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)__resource).Id; }

        /// <summary>
        /// Differentiates between the type of script commands included - Database or Cluster. The default is Database.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ScriptLevel? Level { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptPropertiesInternal)Property).ScriptLevel; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptPropertiesInternal)Property).ScriptLevel = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ScriptLevel)""); }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)__resource).Type = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptProperties Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.ScriptProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20.ISystemData Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal.SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20.SystemData()); set { {_systemData = value;} } }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)__resource).Name; }

        /// <summary>
        /// Indicates if the permissions for the script caller are kept following completion of the script.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.PrincipalPermissionsAction? PrincipalPermissionsAction { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptPropertiesInternal)Property).PrincipalPermissionsAction; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptPropertiesInternal)Property).PrincipalPermissionsAction = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.PrincipalPermissionsAction)""); }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptProperties _property;

        /// <summary>The database script.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.ScriptProperties()); set => this._property = value; }

        /// <summary>The provisioned state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Backing field for <see cref="SystemData" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20.ISystemData _systemData;

        /// <summary>Metadata pertaining to creation and last modification of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20.ISystemData SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20.SystemData()); }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inlined)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20.ISystemDataInternal)SystemData).CreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20.ISystemDataInternal)SystemData).CreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inlined)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20.ISystemDataInternal)SystemData).CreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20.ISystemDataInternal)SystemData).CreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.CreatedByType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20.ISystemDataInternal)SystemData).CreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20.ISystemDataInternal)SystemData).CreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.CreatedByType)""); }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inlined)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20.ISystemDataInternal)SystemData).LastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20.ISystemDataInternal)SystemData).LastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inlined)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20.ISystemDataInternal)SystemData).LastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20.ISystemDataInternal)SystemData).LastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.CreatedByType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20.ISystemDataInternal)SystemData).LastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20.ISystemDataInternal)SystemData).LastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.CreatedByType)""); }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)__resource).Type; }

        /// <summary>
        /// The url to the KQL script blob file. Must not be used together with scriptContent property
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inlined)]
        public string Url { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptPropertiesInternal)Property).ScriptUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptPropertiesInternal)Property).ScriptUrl = value ?? null; }

        /// <summary>
        /// The SaS token that provide read access to the file which contain the script. Must be provided when using scriptUrl property.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inlined)]
        public string UrlSasToken { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptPropertiesInternal)Property).ScriptUrlSasToken; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptPropertiesInternal)Property).ScriptUrlSasToken = value ?? null; }

        /// <summary>Creates an new <see cref="Script" /> instance.</summary>
        public Script()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Class representing a database script.
    public partial interface IScript :
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResource
    {
        /// <summary>
        /// The script content. This property should be used when the script is provide inline and not through file in a SA. Must
        /// not be used together with scriptUrl and scriptUrlSasToken properties.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The script content. This property should be used when the script is provide inline and not through file in a SA. Must not be used together with scriptUrl and scriptUrlSasToken properties.",
        SerializedName = @"scriptContent",
        PossibleTypes = new [] { typeof(string) })]
        string Content { get; set; }
        /// <summary>Flag that indicates whether to continue if one of the command fails.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Flag that indicates whether to continue if one of the command fails.",
        SerializedName = @"continueOnErrors",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ContinueOnError { get; set; }
        /// <summary>A unique string. If changed the script will be applied again.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A unique string. If changed the script will be applied again.",
        SerializedName = @"forceUpdateTag",
        PossibleTypes = new [] { typeof(string) })]
        string ForceUpdateTag { get; set; }
        /// <summary>
        /// Differentiates between the type of script commands included - Database or Cluster. The default is Database.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Differentiates between the type of script commands included - Database or Cluster. The default is Database.",
        SerializedName = @"scriptLevel",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ScriptLevel) })]
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ScriptLevel? Level { get; set; }
        /// <summary>
        /// Indicates if the permissions for the script caller are kept following completion of the script.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates if the permissions for the script caller are kept following completion of the script.",
        SerializedName = @"principalPermissionsAction",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.PrincipalPermissionsAction) })]
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.PrincipalPermissionsAction? PrincipalPermissionsAction { get; set; }
        /// <summary>The provisioned state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioned state of the resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timestamp of resource creation (UTC).",
        SerializedName = @"createdAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity that created the resource.",
        SerializedName = @"createdBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity that created the resource.",
        SerializedName = @"createdByType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.CreatedByType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.CreatedByType? SystemDataCreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timestamp of resource last modification (UTC)",
        SerializedName = @"lastModifiedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity that last modified the resource.",
        SerializedName = @"lastModifiedBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity that last modified the resource.",
        SerializedName = @"lastModifiedByType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.CreatedByType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.CreatedByType? SystemDataLastModifiedByType { get; set; }
        /// <summary>
        /// The url to the KQL script blob file. Must not be used together with scriptContent property
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The url to the KQL script blob file. Must not be used together with scriptContent property",
        SerializedName = @"scriptUrl",
        PossibleTypes = new [] { typeof(string) })]
        string Url { get; set; }
        /// <summary>
        /// The SaS token that provide read access to the file which contain the script. Must be provided when using scriptUrl property.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The SaS token that provide read access to the file which contain the script. Must be provided when using scriptUrl property.",
        SerializedName = @"scriptUrlSasToken",
        PossibleTypes = new [] { typeof(string) })]
        string UrlSasToken { get; set; }

    }
    /// Class representing a database script.
    internal partial interface IScriptInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal
    {
        /// <summary>
        /// The script content. This property should be used when the script is provide inline and not through file in a SA. Must
        /// not be used together with scriptUrl and scriptUrlSasToken properties.
        /// </summary>
        string Content { get; set; }
        /// <summary>Flag that indicates whether to continue if one of the command fails.</summary>
        bool? ContinueOnError { get; set; }
        /// <summary>A unique string. If changed the script will be applied again.</summary>
        string ForceUpdateTag { get; set; }
        /// <summary>
        /// Differentiates between the type of script commands included - Database or Cluster. The default is Database.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ScriptLevel? Level { get; set; }
        /// <summary>
        /// Indicates if the permissions for the script caller are kept following completion of the script.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.PrincipalPermissionsAction? PrincipalPermissionsAction { get; set; }
        /// <summary>The database script.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptProperties Property { get; set; }
        /// <summary>The provisioned state of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>Metadata pertaining to creation and last modification of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20.ISystemData SystemData { get; set; }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        string SystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.CreatedByType? SystemDataCreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        global::System.DateTime? SystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        string SystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.CreatedByType? SystemDataLastModifiedByType { get; set; }
        /// <summary>
        /// The url to the KQL script blob file. Must not be used together with scriptContent property
        /// </summary>
        string Url { get; set; }
        /// <summary>
        /// The SaS token that provide read access to the file which contain the script. Must be provided when using scriptUrl property.
        /// </summary>
        string UrlSasToken { get; set; }

    }
}
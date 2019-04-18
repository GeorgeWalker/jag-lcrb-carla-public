// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// adoxio_policejurisdiction
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioPolicejurisdiction
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioPolicejurisdiction class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioPolicejurisdiction()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioPolicejurisdiction class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioPolicejurisdiction(int? importsequencenumber = default(int?), string _createdonbehalfbyValue = default(string), string _createdbyValue = default(string), string adoxioEmail = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? timezoneruleversionnumber = default(int?), string adoxioFaxnumber = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? statecode = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string adoxioPolicejurisdictionid = default(string), string _modifiedbyValue = default(string), string _organizationidValue = default(string), int? statuscode = default(int?), string _modifiedonbehalfbyValue = default(string), string adoxioPosition = default(string), string adoxioPhonenumber = default(string), string adoxioName = default(string), int? utcconversiontimezonecode = default(int?), string adoxioContactname = default(string), long? versionnumber = default(long?), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMsyncerror> adoxioPolicejurisdictionSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioPolicejurisdictionDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioPolicejurisdictionDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioPolicejurisdictionAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioPolicejurisdictionBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMadoxioApplication> adoxioPolicejurisdictionApplications = default(IList<MicrosoftDynamicsCRMadoxioApplication>), IList<MicrosoftDynamicsCRMadoxioEstablishment> adoxioPolicejurisdictionAdoxioEstablishmentPDJurisdiction = default(IList<MicrosoftDynamicsCRMadoxioEstablishment>), IList<MicrosoftDynamicsCRMadoxioLicences> adoxioPolicejurisdictionAdoxioLicencesPDJurisdiction = default(IList<MicrosoftDynamicsCRMadoxioLicences>))
        {
            Importsequencenumber = importsequencenumber;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._createdbyValue = _createdbyValue;
            AdoxioEmail = adoxioEmail;
            Createdon = createdon;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            AdoxioFaxnumber = adoxioFaxnumber;
            Modifiedon = modifiedon;
            Statecode = statecode;
            Overriddencreatedon = overriddencreatedon;
            AdoxioPolicejurisdictionid = adoxioPolicejurisdictionid;
            this._modifiedbyValue = _modifiedbyValue;
            this._organizationidValue = _organizationidValue;
            Statuscode = statuscode;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            AdoxioPosition = adoxioPosition;
            AdoxioPhonenumber = adoxioPhonenumber;
            AdoxioName = adoxioName;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            AdoxioContactname = adoxioContactname;
            Versionnumber = versionnumber;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Organizationid = organizationid;
            AdoxioPolicejurisdictionSyncErrors = adoxioPolicejurisdictionSyncErrors;
            AdoxioPolicejurisdictionDuplicateMatchingRecord = adoxioPolicejurisdictionDuplicateMatchingRecord;
            AdoxioPolicejurisdictionDuplicateBaseRecord = adoxioPolicejurisdictionDuplicateBaseRecord;
            AdoxioPolicejurisdictionAsyncOperations = adoxioPolicejurisdictionAsyncOperations;
            AdoxioPolicejurisdictionBulkDeleteFailures = adoxioPolicejurisdictionBulkDeleteFailures;
            AdoxioPolicejurisdictionApplications = adoxioPolicejurisdictionApplications;
            AdoxioPolicejurisdictionAdoxioEstablishmentPDJurisdiction = adoxioPolicejurisdictionAdoxioEstablishmentPDJurisdiction;
            AdoxioPolicejurisdictionAdoxioLicencesPDJurisdiction = adoxioPolicejurisdictionAdoxioLicencesPDJurisdiction;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_email")]
        public string AdoxioEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_faxnumber")]
        public string AdoxioFaxnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_policejurisdictionid")]
        public string AdoxioPolicejurisdictionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_position")]
        public string AdoxioPosition { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_phonenumber")]
        public string AdoxioPhonenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contactname")]
        public string AdoxioContactname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_policejurisdiction_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioPolicejurisdictionSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_policejurisdiction_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioPolicejurisdictionDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_policejurisdiction_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioPolicejurisdictionDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_policejurisdiction_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioPolicejurisdictionAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_policejurisdiction_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioPolicejurisdictionBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_policejurisdiction_applications")]
        public IList<MicrosoftDynamicsCRMadoxioApplication> AdoxioPolicejurisdictionApplications { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_policejurisdiction_adoxio_establishment_PDJurisdiction")]
        public IList<MicrosoftDynamicsCRMadoxioEstablishment> AdoxioPolicejurisdictionAdoxioEstablishmentPDJurisdiction { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_policejurisdiction_adoxio_licences_PDJurisdiction")]
        public IList<MicrosoftDynamicsCRMadoxioLicences> AdoxioPolicejurisdictionAdoxioLicencesPDJurisdiction { get; set; }

    }
}

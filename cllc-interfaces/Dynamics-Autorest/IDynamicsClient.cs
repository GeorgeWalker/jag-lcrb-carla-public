// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// This OData service is located at http://localhost
    /// </summary>
    public partial interface IDynamicsClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Show only the first n items
        /// </summary>
        int? Top101 { get; set; }

        /// <summary>
        /// Skip the first n items
        /// </summary>
        int? Skip101 { get; set; }

        /// <summary>
        /// Include count of items
        /// </summary>
        bool? Count101 { get; set; }

        /// <summary>
        /// Filter items by property values
        /// </summary>
        string Filter101 { get; set; }

        /// <summary>
        /// Search items by search phrases
        /// </summary>
        string Search101 { get; set; }

        /// <summary>
        /// Subscription credentials which uniquely identify client
        /// subscription.
        /// </summary>
        ServiceClientCredentials Credentials { get; }


        /// <summary>
        /// Gets the IAccounts.
        /// </summary>
        IAccounts Accounts { get; }

        /// <summary>
        /// Gets the IPartyidadoxiolocalgovindigenousnation.
        /// </summary>
        IPartyidadoxiolocalgovindigenousnation Partyidadoxiolocalgovindigenousnation { get; }

        /// <summary>
        /// Gets the IAdoxiolicencetypeadoxioinvestigationset.
        /// </summary>
        IAdoxiolicencetypeadoxioinvestigationset Adoxiolicencetypeadoxioinvestigationset { get; }

        /// <summary>
        /// Gets the IAliases.
        /// </summary>
        IAliases Aliases { get; }

        /// <summary>
        /// Gets the IAnnualvolumes.
        /// </summary>
        IAnnualvolumes Annualvolumes { get; }

        /// <summary>
        /// Gets the IApplicationbpfv3s.
        /// </summary>
        IApplicationbpfv3s Applicationbpfv3s { get; }

        /// <summary>
        /// Gets the IApplicationcrsbpfv4s.
        /// </summary>
        IApplicationcrsbpfv4s Applicationcrsbpfv4s { get; }

        /// <summary>
        /// Gets the IApplicationinvoicehistories.
        /// </summary>
        IApplicationinvoicehistories Applicationinvoicehistories { get; }

        /// <summary>
        /// Gets the IApplicationlicenseechangesv10s.
        /// </summary>
        IApplicationlicenseechangesv10s Applicationlicenseechangesv10s { get; }

        /// <summary>
        /// Gets the IApplicationliquorbpfs.
        /// </summary>
        IApplicationliquorbpfs Applicationliquorbpfs { get; }

        /// <summary>
        /// Gets the IApplicationliquorbpfv2s.
        /// </summary>
        IApplicationliquorbpfv2s Applicationliquorbpfv2s { get; }

        /// <summary>
        /// Gets the IApplicationrelocationv1s.
        /// </summary>
        IApplicationrelocationv1s Applicationrelocationv1s { get; }

        /// <summary>
        /// Gets the IApplications.
        /// </summary>
        IApplications Applications { get; }

        /// <summary>
        /// Gets the IApplicationstructurechangev1s.
        /// </summary>
        IApplicationstructurechangev1s Applicationstructurechangev1s { get; }

        /// <summary>
        /// Gets the IApplicationtermsconditionslimitations.
        /// </summary>
        IApplicationtermsconditionslimitations Applicationtermsconditionslimitations { get; }

        /// <summary>
        /// Gets the IApplicationtransferownershipv1s.
        /// </summary>
        IApplicationtransferownershipv1s Applicationtransferownershipv1s { get; }

        /// <summary>
        /// Gets the IApplicationtypecontents.
        /// </summary>
        IApplicationtypecontents Applicationtypecontents { get; }

        /// <summary>
        /// Gets the IApplicationtypefeeschedules.
        /// </summary>
        IApplicationtypefeeschedules Applicationtypefeeschedules { get; }

        /// <summary>
        /// Gets the IApplicationtypes.
        /// </summary>
        IApplicationtypes Applicationtypes { get; }

        /// <summary>
        /// Gets the IApplicationtypeadoxiotermsconditionslimitationspresetapplicationtype.
        /// </summary>
        IApplicationtypeadoxiotermsconditionslimitationspresetapplicationtype Applicationtypeadoxiotermsconditionslimitationspresetapplicationtype { get; }

        /// <summary>
        /// Gets the IAreas.
        /// </summary>
        IAreas Areas { get; }

        /// <summary>
        /// Gets the IAuditlogrequests.
        /// </summary>
        IAuditlogrequests Auditlogrequests { get; }

        /// <summary>
        /// Gets the IBusinessaccounts.
        /// </summary>
        IBusinessaccounts Businessaccounts { get; }

        /// <summary>
        /// Gets the ICannabisinventoryreports.
        /// </summary>
        ICannabisinventoryreports Cannabisinventoryreports { get; }

        /// <summary>
        /// Gets the ICannabismonthlyreports.
        /// </summary>
        ICannabismonthlyreports Cannabismonthlyreports { get; }

        /// <summary>
        /// Gets the ICannabisproductadmins.
        /// </summary>
        ICannabisproductadmins Cannabisproductadmins { get; }

        /// <summary>
        /// Gets the ICitydistricts.
        /// </summary>
        ICitydistricts Citydistricts { get; }

        /// <summary>
        /// Gets the IComplaints.
        /// </summary>
        IComplaints Complaints { get; }

        /// <summary>
        /// Gets the IComplianceinvestigations.
        /// </summary>
        IComplianceinvestigations Complianceinvestigations { get; }

        /// <summary>
        /// Gets the ICompliancemeetings.
        /// </summary>
        ICompliancemeetings Compliancemeetings { get; }

        /// <summary>
        /// Gets the IContraventionadmins.
        /// </summary>
        IContraventionadmins Contraventionadmins { get; }

        /// <summary>
        /// Gets the IContraventions.
        /// </summary>
        IContraventions Contraventions { get; }

        /// <summary>
        /// Gets the ICorporatehistorysummaries.
        /// </summary>
        ICorporatehistorysummaries Corporatehistorysummaries { get; }

        /// <summary>
        /// Gets the ICorporateroles.
        /// </summary>
        ICorporateroles Corporateroles { get; }

        /// <summary>
        /// Gets the ICustomautonumberdefinitions.
        /// </summary>
        ICustomautonumberdefinitions Customautonumberdefinitions { get; }

        /// <summary>
        /// Gets the ICustomautonumberrequests.
        /// </summary>
        ICustomautonumberrequests Customautonumberrequests { get; }

        /// <summary>
        /// Gets the IDocumentadmins.
        /// </summary>
        IDocumentadmins Documentadmins { get; }

        /// <summary>
        /// Gets the IDocuments.
        /// </summary>
        IDocuments Documents { get; }

        /// <summary>
        /// Gets the IEndorsements.
        /// </summary>
        IEndorsements Endorsements { get; }

        /// <summary>
        /// Gets the IEnforcementactionbpfs.
        /// </summary>
        IEnforcementactionbpfs Enforcementactionbpfs { get; }

        /// <summary>
        /// Gets the IEnforcementactions.
        /// </summary>
        IEnforcementactions Enforcementactions { get; }

        /// <summary>
        /// Gets the IEstablishmentincidents.
        /// </summary>
        IEstablishmentincidents Establishmentincidents { get; }

        /// <summary>
        /// Gets the IEstablishments.
        /// </summary>
        IEstablishments Establishments { get; }

        /// <summary>
        /// Gets the IEstablishmentwatchwords.
        /// </summary>
        IEstablishmentwatchwords Establishmentwatchwords { get; }

        /// <summary>
        /// Gets the IEvents.
        /// </summary>
        IEvents Events { get; }

        /// <summary>
        /// Gets the IEventschedules.
        /// </summary>
        IEventschedules Eventschedules { get; }

        /// <summary>
        /// Gets the IExhibits.
        /// </summary>
        IExhibits Exhibits { get; }

        /// <summary>
        /// Gets the IFederalreportexports.
        /// </summary>
        IFederalreportexports Federalreportexports { get; }

        /// <summary>
        /// Gets the IFiainvestigationlogs.
        /// </summary>
        IFiainvestigationlogs Fiainvestigationlogs { get; }

        /// <summary>
        /// Gets the IFormelementuploadfields.
        /// </summary>
        IFormelementuploadfields Formelementuploadfields { get; }

        /// <summary>
        /// Gets the IFundingsources.
        /// </summary>
        IFundingsources Fundingsources { get; }

        /// <summary>
        /// Gets the IIncidentadoxiolicencetypeset.
        /// </summary>
        IIncidentadoxiolicencetypeset Incidentadoxiolicencetypeset { get; }

        /// <summary>
        /// Gets the IInspectioninspectorsset.
        /// </summary>
        IInspectioninspectorsset Inspectioninspectorsset { get; }

        /// <summary>
        /// Gets the IInspectionreactivationhistories.
        /// </summary>
        IInspectionreactivationhistories Inspectionreactivationhistories { get; }

        /// <summary>
        /// Gets the IInspectorcommentsrollups.
        /// </summary>
        IInspectorcommentsrollups Inspectorcommentsrollups { get; }

        /// <summary>
        /// Gets the IInterests.
        /// </summary>
        IInterests Interests { get; }

        /// <summary>
        /// Gets the IInvestigationactivities.
        /// </summary>
        IInvestigationactivities Investigationactivities { get; }

        /// <summary>
        /// Gets the IInvestigationreactivationhistories.
        /// </summary>
        IInvestigationreactivationhistories Investigationreactivationhistories { get; }

        /// <summary>
        /// Gets the IInvestigations.
        /// </summary>
        IInvestigations Investigations { get; }

        /// <summary>
        /// Gets the ILdborders.
        /// </summary>
        ILdborders Ldborders { get; }

        /// <summary>
        /// Gets the ILegalentities.
        /// </summary>
        ILegalentities Legalentities { get; }

        /// <summary>
        /// Gets the ILicenceldbordertotalhistories.
        /// </summary>
        ILicenceldbordertotalhistories Licenceldbordertotalhistories { get; }

        /// <summary>
        /// Gets the ILicenceses.
        /// </summary>
        ILicenceses Licenceses { get; }

        /// <summary>
        /// Gets the ILicencesubcategories.
        /// </summary>
        ILicencesubcategories Licencesubcategories { get; }

        /// <summary>
        /// Gets the ILicencetypes.
        /// </summary>
        ILicencetypes Licencetypes { get; }

        /// <summary>
        /// Gets the ILicencetypesapplicationtypesset.
        /// </summary>
        ILicencetypesapplicationtypesset Licencetypesapplicationtypesset { get; }

        /// <summary>
        /// Gets the ILicenseechangelogs.
        /// </summary>
        ILicenseechangelogs Licenseechangelogs { get; }

        /// <summary>
        /// Gets the ILoans.
        /// </summary>
        ILoans Loans { get; }

        /// <summary>
        /// Gets the ILocalgovindigenousnations.
        /// </summary>
        ILocalgovindigenousnations Localgovindigenousnations { get; }

        /// <summary>
        /// Gets the ILocalgovindigenousnationactivityparties.
        /// </summary>
        ILocalgovindigenousnationactivityparties Localgovindigenousnationactivityparties { get; }

        /// <summary>
        /// Gets the IPersonalhistorysummaries.
        /// </summary>
        IPersonalhistorysummaries Personalhistorysummaries { get; }

        /// <summary>
        /// Gets the IPolicejurisdictions.
        /// </summary>
        IPolicejurisdictions Policejurisdictions { get; }

        /// <summary>
        /// Gets the IPolicydocuments.
        /// </summary>
        IPolicydocuments Policydocuments { get; }

        /// <summary>
        /// Gets the IPostalcodes.
        /// </summary>
        IPostalcodes Postalcodes { get; }

        /// <summary>
        /// Gets the IPreviousaddresses.
        /// </summary>
        IPreviousaddresses Previousaddresses { get; }

        /// <summary>
        /// Gets the IRegions.
        /// </summary>
        IRegions Regions { get; }

        /// <summary>
        /// Gets the IRelatedparties.
        /// </summary>
        IRelatedparties Relatedparties { get; }

        /// <summary>
        /// Gets the IRmreviews.
        /// </summary>
        IRmreviews Rmreviews { get; }

        /// <summary>
        /// Gets the IServiceareas.
        /// </summary>
        IServiceareas Serviceareas { get; }

        /// <summary>
        /// Gets the ISettings.
        /// </summary>
        ISettings Settings { get; }

        /// <summary>
        /// Gets the ISpddatarows.
        /// </summary>
        ISpddatarows Spddatarows { get; }

        /// <summary>
        /// Gets the ISpdexportses.
        /// </summary>
        ISpdexportses Spdexportses { get; }

        /// <summary>
        /// Gets the ITaxandaccountings.
        /// </summary>
        ITaxandaccountings Taxandaccountings { get; }

        /// <summary>
        /// Gets the ITermsconditionslimitationspresets.
        /// </summary>
        ITermsconditionslimitationspresets Termsconditionslimitationspresets { get; }

        /// <summary>
        /// Gets the IApplicationtype.
        /// </summary>
        IApplicationtype Applicationtype { get; }

        /// <summary>
        /// Gets the ITerritories.
        /// </summary>
        ITerritories Territories { get; }

        /// <summary>
        /// Gets the ITiedhouseassociations.
        /// </summary>
        ITiedhouseassociations Tiedhouseassociations { get; }

        /// <summary>
        /// Gets the ITiedhouseconnections.
        /// </summary>
        ITiedhouseconnections Tiedhouseconnections { get; }

        /// <summary>
        /// Gets the IWitnesses.
        /// </summary>
        IWitnesses Witnesses { get; }

        /// <summary>
        /// Gets the IWorkerinvoicehistories.
        /// </summary>
        IWorkerinvoicehistories Workerinvoicehistories { get; }

        /// <summary>
        /// Gets the IWorkers.
        /// </summary>
        IWorkers Workers { get; }

        /// <summary>
        /// Gets the IContacts.
        /// </summary>
        IContacts Contacts { get; }

        /// <summary>
        /// Gets the IEntitydefinitions.
        /// </summary>
        IEntitydefinitions Entitydefinitions { get; }

        /// <summary>
        /// Gets the IGlobaloptionsetdefinitions.
        /// </summary>
        IGlobaloptionsetdefinitions Globaloptionsetdefinitions { get; }

        /// <summary>
        /// Gets the IInvoices.
        /// </summary>
        IInvoices Invoices { get; }

        /// <summary>
        /// Gets the ILeads.
        /// </summary>
        ILeads Leads { get; }

        /// <summary>
        /// Gets the ILists.
        /// </summary>
        ILists Lists { get; }

        /// <summary>
        /// Gets the ISavedqueries.
        /// </summary>
        ISavedqueries Savedqueries { get; }

        /// <summary>
        /// Gets the ISharepointdocumentlocations.
        /// </summary>
        ISharepointdocumentlocations Sharepointdocumentlocations { get; }

        /// <summary>
        /// Gets the ISharepointsites.
        /// </summary>
        ISharepointsites Sharepointsites { get; }

        /// <summary>
        /// Gets the ISystemforms.
        /// </summary>
        ISystemforms Systemforms { get; }

        /// <summary>
        /// Gets the IWorkflows.
        /// </summary>
        IWorkflows Workflows { get; }

    }
}

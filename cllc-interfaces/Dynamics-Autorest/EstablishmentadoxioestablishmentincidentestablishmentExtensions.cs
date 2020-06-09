// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Establishmentadoxioestablishmentincidentestablishment.
    /// </summary>
    public static partial class EstablishmentadoxioestablishmentincidentestablishmentExtensions
    {
            /// <summary>
            /// Get adoxio_establishment_adoxio_establishmentincident_Establishment from
            /// adoxio_establishments
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioEstablishmentid'>
            /// key: adoxio_establishmentid of adoxio_establishment
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMadoxioEstablishmentincidentCollection Get(this IEstablishmentadoxioestablishmentincidentestablishment operations, string adoxioEstablishmentid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(adoxioEstablishmentid, top, skip, search, filter, count, orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_establishment_adoxio_establishmentincident_Establishment from
            /// adoxio_establishments
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioEstablishmentid'>
            /// key: adoxio_establishmentid of adoxio_establishment
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMadoxioEstablishmentincidentCollection> GetAsync(this IEstablishmentadoxioestablishmentincidentestablishment operations, string adoxioEstablishmentid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(adoxioEstablishmentid, top, skip, search, filter, count, orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get adoxio_establishment_adoxio_establishmentincident_Establishment from
            /// adoxio_establishments
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioEstablishmentid'>
            /// key: adoxio_establishmentid of adoxio_establishment
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioEstablishmentincidentCollection> GetWithHttpMessages(this IEstablishmentadoxioestablishmentincidentestablishment operations, string adoxioEstablishmentid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetWithHttpMessagesAsync(adoxioEstablishmentid, top, skip, search, filter, count, orderby, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_establishment_adoxio_establishmentincident_Establishment from
            /// adoxio_establishments
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioEstablishmentid'>
            /// key: adoxio_establishmentid of adoxio_establishment
            /// </param>
            /// <param name='adoxioEstablishmentincidentid'>
            /// key: adoxio_establishmentincidentid of adoxio_establishmentincident
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMadoxioEstablishmentincident EstablishmentByKey(this IEstablishmentadoxioestablishmentincidentestablishment operations, string adoxioEstablishmentid, string adoxioEstablishmentincidentid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.EstablishmentByKeyAsync(adoxioEstablishmentid, adoxioEstablishmentincidentid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_establishment_adoxio_establishmentincident_Establishment from
            /// adoxio_establishments
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioEstablishmentid'>
            /// key: adoxio_establishmentid of adoxio_establishment
            /// </param>
            /// <param name='adoxioEstablishmentincidentid'>
            /// key: adoxio_establishmentincidentid of adoxio_establishmentincident
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMadoxioEstablishmentincident> EstablishmentByKeyAsync(this IEstablishmentadoxioestablishmentincidentestablishment operations, string adoxioEstablishmentid, string adoxioEstablishmentincidentid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.EstablishmentByKeyWithHttpMessagesAsync(adoxioEstablishmentid, adoxioEstablishmentincidentid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get adoxio_establishment_adoxio_establishmentincident_Establishment from
            /// adoxio_establishments
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioEstablishmentid'>
            /// key: adoxio_establishmentid of adoxio_establishment
            /// </param>
            /// <param name='adoxioEstablishmentincidentid'>
            /// key: adoxio_establishmentincidentid of adoxio_establishmentincident
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioEstablishmentincident> EstablishmentByKeyWithHttpMessages(this IEstablishmentadoxioestablishmentincidentestablishment operations, string adoxioEstablishmentid, string adoxioEstablishmentincidentid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.EstablishmentByKeyWithHttpMessagesAsync(adoxioEstablishmentid, adoxioEstablishmentincidentid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

    }
}
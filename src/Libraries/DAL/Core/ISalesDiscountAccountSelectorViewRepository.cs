// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ISalesDiscountAccountSelectorViewRepository
    {
        /// <summary>
        /// Performs count on ISalesDiscountAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the number of ISalesDiscountAccountSelectorViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "SalesDiscountAccountSelectorView" class from ISalesDiscountAccountSelectorViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "SalesDiscountAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesDiscountAccountSelectorView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ISalesDiscountAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ISalesDiscountAccountSelectorViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from ISalesDiscountAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "SalesDiscountAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesDiscountAccountSelectorView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from ISalesDiscountAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "SalesDiscountAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesDiscountAccountSelectorView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ISalesDiscountAccountSelectorViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "SalesDiscountAccountSelectorView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from ISalesDiscountAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "SalesDiscountAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesDiscountAccountSelectorView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ISalesDiscountAccountSelectorViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "SalesDiscountAccountSelectorView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from ISalesDiscountAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "SalesDiscountAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesDiscountAccountSelectorView> GetFiltered(long pageNumber, string filterName);


    }
}
namespace Azure.Analytics.Purview.Catalog
{
    public partial class CatalogClientOptions : Azure.Core.ClientOptions
    {
        public CatalogClientOptions(Azure.Analytics.Purview.Catalog.CatalogClientOptions.ServiceVersion version = Azure.Analytics.Purview.Catalog.CatalogClientOptions.ServiceVersion.V2020_12_01_preview) { }
        public enum ServiceVersion
        {
            V2020_12_01_preview = 1,
        }
    }
    public partial class DiscoveryRestClient
    {
        protected DiscoveryRestClient() { }
        public DiscoveryRestClient(System.Uri endpoint, Azure.Core.TokenCredential credential, Azure.Analytics.Purview.Catalog.CatalogClientOptions options = null) { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.Response AutoComplete(Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> AutoCompleteAsync(Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response SearchAdvanced(Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> SearchAdvancedAsync(Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response Suggest(Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> SuggestAsync(Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
    }
    public partial class EntityRestClient
    {
        protected EntityRestClient() { }
        public EntityRestClient(System.Uri endpoint, Azure.Core.TokenCredential credential, Azure.Analytics.Purview.Catalog.CatalogClientOptions options = null) { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.Response AddClassification(Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> AddClassificationAsync(Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response AddClassifications(string guid, Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> AddClassificationsAsync(string guid, Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response AddClassificationsByUniqueAttribute(string typeName, Azure.Core.RequestContent requestBody, string attrQualifiedName = null, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> AddClassificationsByUniqueAttributeAsync(string typeName, Azure.Core.RequestContent requestBody, string attrQualifiedName = null, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response BulkDelete(System.Collections.Generic.IEnumerable<string> guid, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> BulkDeleteAsync(System.Collections.Generic.IEnumerable<string> guid, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response CreateOrUpdate(Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CreateOrUpdateAsync(Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response CreateOrUpdateBulk(Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CreateOrUpdateBulkAsync(Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response DeleteByGuid(string guid, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteByGuidAsync(string guid, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response DeleteByUniqueAttribute(string typeName, string attrQualifiedName = null, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteByUniqueAttributeAsync(string typeName, string attrQualifiedName = null, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response DeleteClassification(string guid, string classificationName, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteClassificationAsync(string guid, string classificationName, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response DeleteClassificationByUniqueAttribute(string typeName, string classificationName, string attrQualifiedName = null, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteClassificationByUniqueAttributeAsync(string typeName, string classificationName, string attrQualifiedName = null, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response GetByGuids(System.Collections.Generic.IEnumerable<string> guid, bool? minExtInfo = default(bool?), bool? ignoreRelationships = default(bool?), System.Collections.Generic.IEnumerable<string> excludeRelationshipTypes = null, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetByGuidsAsync(System.Collections.Generic.IEnumerable<string> guid, bool? minExtInfo = default(bool?), bool? ignoreRelationships = default(bool?), System.Collections.Generic.IEnumerable<string> excludeRelationshipTypes = null, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response GetById(string guid, bool? minExtInfo = default(bool?), bool? ignoreRelationships = default(bool?), Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetByIdAsync(string guid, bool? minExtInfo = default(bool?), bool? ignoreRelationships = default(bool?), Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response GetByUniqueAttributes(string typeName, bool? minExtInfo = default(bool?), bool? ignoreRelationships = default(bool?), string attrQualifiedName = null, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetByUniqueAttributesAsync(string typeName, bool? minExtInfo = default(bool?), bool? ignoreRelationships = default(bool?), string attrQualifiedName = null, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response GetClassification(string guid, string classificationName, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetClassificationAsync(string guid, string classificationName, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response GetClassifications(string guid, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetClassificationsAsync(string guid, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response GetEntitiesByUniqueAttributes(string typeName, bool? minExtInfo = default(bool?), bool? ignoreRelationships = default(bool?), string attrNQualifiedName = null, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetEntitiesByUniqueAttributesAsync(string typeName, bool? minExtInfo = default(bool?), bool? ignoreRelationships = default(bool?), string attrNQualifiedName = null, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response GetHeaderById(string guid, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetHeaderByIdAsync(string guid, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response PartialUpdateEntityAttrByGuid(string guid, string name, Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> PartialUpdateEntityAttrByGuidAsync(string guid, string name, Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response PartialUpdateEntityByUniqueAttrs(string typeName, Azure.Core.RequestContent requestBody, string attrQualifiedName = null, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> PartialUpdateEntityByUniqueAttrsAsync(string typeName, Azure.Core.RequestContent requestBody, string attrQualifiedName = null, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response SetClassifications(Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> SetClassificationsAsync(Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response UpdateClassifications(string guid, Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> UpdateClassificationsAsync(string guid, Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response UpdateClassificationsByUniqueAttribute(string typeName, Azure.Core.RequestContent requestBody, string attrQualifiedName = null, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> UpdateClassificationsByUniqueAttributeAsync(string typeName, Azure.Core.RequestContent requestBody, string attrQualifiedName = null, Azure.RequestOptions requestOptions = null) { throw null; }
    }
    public partial class GlossaryRestClient
    {
        protected GlossaryRestClient() { }
        public GlossaryRestClient(System.Uri endpoint, Azure.Core.TokenCredential credential, Azure.Analytics.Purview.Catalog.CatalogClientOptions options = null) { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.Response AssignTermToEntities(string termGuid, Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> AssignTermToEntitiesAsync(string termGuid, Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response CreateGlossary(Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CreateGlossaryAsync(Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response CreateGlossaryCategories(Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CreateGlossaryCategoriesAsync(Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response CreateGlossaryCategory(Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CreateGlossaryCategoryAsync(Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response CreateGlossaryTerm(Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CreateGlossaryTermAsync(Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response CreateGlossaryTerms(Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CreateGlossaryTermsAsync(Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response DeleteGlossary(string glossaryGuid, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteGlossaryAsync(string glossaryGuid, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response DeleteGlossaryCategory(string categoryGuid, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteGlossaryCategoryAsync(string categoryGuid, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response DeleteGlossaryTerm(string termGuid, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteGlossaryTermAsync(string termGuid, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response DeleteTermAssignmentFromEntities(string termGuid, Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteTermAssignmentFromEntitiesAsync(string termGuid, Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response ExportGlossaryTermsAsCSV(string glossaryGuid, Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> ExportGlossaryTermsAsCSVAsync(string glossaryGuid, Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response GetCategoryTerms(string categoryGuid, int? limit = default(int?), int? offset = default(int?), string sort = null, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetCategoryTermsAsync(string categoryGuid, int? limit = default(int?), int? offset = default(int?), string sort = null, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response GetDetailedGlossary(string glossaryGuid, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetDetailedGlossaryAsync(string glossaryGuid, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response GetEntitiesAssignedWithTerm(string termGuid, int? limit = default(int?), int? offset = default(int?), string sort = null, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetEntitiesAssignedWithTermAsync(string termGuid, int? limit = default(int?), int? offset = default(int?), string sort = null, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response GetGlossaries(int? limit = default(int?), int? offset = default(int?), string sort = null, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetGlossariesAsync(int? limit = default(int?), int? offset = default(int?), string sort = null, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response GetGlossary(string glossaryGuid, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetGlossaryAsync(string glossaryGuid, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response GetGlossaryCategories(string glossaryGuid, int? limit = default(int?), int? offset = default(int?), string sort = null, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetGlossaryCategoriesAsync(string glossaryGuid, int? limit = default(int?), int? offset = default(int?), string sort = null, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response GetGlossaryCategoriesHeaders(string glossaryGuid, int? limit = default(int?), int? offset = default(int?), string sort = null, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetGlossaryCategoriesHeadersAsync(string glossaryGuid, int? limit = default(int?), int? offset = default(int?), string sort = null, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response GetGlossaryCategory(string categoryGuid, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetGlossaryCategoryAsync(string categoryGuid, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response GetGlossaryTerm(string termGuid, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetGlossaryTermAsync(string termGuid, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response GetGlossaryTermHeaders(string glossaryGuid, int? limit = default(int?), int? offset = default(int?), string sort = null, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetGlossaryTermHeadersAsync(string glossaryGuid, int? limit = default(int?), int? offset = default(int?), string sort = null, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response GetGlossaryTerms(string glossaryGuid, int? limit = default(int?), int? offset = default(int?), string sort = null, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetGlossaryTermsAsync(string glossaryGuid, int? limit = default(int?), int? offset = default(int?), string sort = null, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response GetImportCSVOperationStatus(string operationGuid, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetImportCSVOperationStatusAsync(string operationGuid, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response GetRelatedCategories(string categoryGuid, int? limit = default(int?), int? offset = default(int?), string sort = null, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetRelatedCategoriesAsync(string categoryGuid, int? limit = default(int?), int? offset = default(int?), string sort = null, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response GetRelatedTerms(string termGuid, int? limit = default(int?), int? offset = default(int?), string sort = null, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetRelatedTermsAsync(string termGuid, int? limit = default(int?), int? offset = default(int?), string sort = null, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response GetTermsByGlossaryName(string glossaryName, int? limit = default(int?), int? offset = default(int?), Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetTermsByGlossaryNameAsync(string glossaryName, int? limit = default(int?), int? offset = default(int?), Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response ImportGlossaryTermsViaCSV(string glossaryGuid, Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> ImportGlossaryTermsViaCSVAsync(string glossaryGuid, Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response ImportGlossaryTermsViaCSVByGlossaryName(string glossaryName, Azure.Core.RequestContent requestBody, bool? includeTermHierarchy = default(bool?), Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> ImportGlossaryTermsViaCSVByGlossaryNameAsync(string glossaryName, Azure.Core.RequestContent requestBody, bool? includeTermHierarchy = default(bool?), Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response PartialUpdateGlossary(string glossaryGuid, Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> PartialUpdateGlossaryAsync(string glossaryGuid, Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response PartialUpdateGlossaryCategory(string categoryGuid, Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> PartialUpdateGlossaryCategoryAsync(string categoryGuid, Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response PartialUpdateGlossaryTerm(string termGuid, Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> PartialUpdateGlossaryTermAsync(string termGuid, Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response RemoveTermAssignmentFromEntities(string termGuid, Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> RemoveTermAssignmentFromEntitiesAsync(string termGuid, Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response UpdateGlossary(string glossaryGuid, Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> UpdateGlossaryAsync(string glossaryGuid, Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response UpdateGlossaryCategory(string categoryGuid, Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> UpdateGlossaryCategoryAsync(string categoryGuid, Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response UpdateGlossaryTerm(string termGuid, Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> UpdateGlossaryTermAsync(string termGuid, Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
    }
    public partial class LineageRestClient
    {
        protected LineageRestClient() { }
        public LineageRestClient(System.Uri endpoint, Azure.Core.TokenCredential credential, Azure.Analytics.Purview.Catalog.CatalogClientOptions options = null) { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.Response GetLineageGraph(string guid, string direction, int? depth = default(int?), int? width = default(int?), bool? includeParent = default(bool?), bool? getDerivedLineage = default(bool?), Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetLineageGraphAsync(string guid, string direction, int? depth = default(int?), int? width = default(int?), bool? includeParent = default(bool?), bool? getDerivedLineage = default(bool?), Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response NextLevelLineage(string guid, string direction, bool? getDerivedLineage = default(bool?), int? offset = default(int?), int? limit = default(int?), Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> NextLevelLineageAsync(string guid, string direction, bool? getDerivedLineage = default(bool?), int? offset = default(int?), int? limit = default(int?), Azure.RequestOptions requestOptions = null) { throw null; }
    }
    public partial class RelationshipRestClient
    {
        protected RelationshipRestClient() { }
        public RelationshipRestClient(System.Uri endpoint, Azure.Core.TokenCredential credential, Azure.Analytics.Purview.Catalog.CatalogClientOptions options = null) { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.Response Create(Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CreateAsync(Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response DeleteById(string guid, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteByIdAsync(string guid, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response GetById2(string guid, bool? extendedInfo = default(bool?), Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetById2Async(string guid, bool? extendedInfo = default(bool?), Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response Update(Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> UpdateAsync(Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
    }
    public partial class TypesRestClient
    {
        protected TypesRestClient() { }
        public TypesRestClient(System.Uri endpoint, Azure.Core.TokenCredential credential, Azure.Analytics.Purview.Catalog.CatalogClientOptions options = null) { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.Response CreateTypeDefs(Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CreateTypeDefsAsync(Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response DeleteTypeByName(string name, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteTypeByNameAsync(string name, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response DeleteTypeDefs(Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteTypeDefsAsync(Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response GetAllTypeDefs(bool? includeTermTemplate = default(bool?), string type = null, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetAllTypeDefsAsync(bool? includeTermTemplate = default(bool?), string type = null, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response GetClassificationDefByGuid(string guid, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetClassificationDefByGuidAsync(string guid, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response GetClassificationDefByName(string name, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetClassificationDefByNameAsync(string name, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response GetEntityDefByGuid(string guid, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetEntityDefByGuidAsync(string guid, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response GetEntityDefByName(string name, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetEntityDefByNameAsync(string name, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response GetEnumDefByGuid(string guid, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetEnumDefByGuidAsync(string guid, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response GetEnumDefByName(string name, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetEnumDefByNameAsync(string name, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response GetRelationshipDefByGuid(string guid, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetRelationshipDefByGuidAsync(string guid, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response GetRelationshipDefByName(string name, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetRelationshipDefByNameAsync(string name, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response GetStructDefByGuid(string guid, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetStructDefByGuidAsync(string guid, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response GetStructDefByName(string name, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetStructDefByNameAsync(string name, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response GetTermTemplateDefByGuid(string guid, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetTermTemplateDefByGuidAsync(string guid, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response GetTermTemplateDefByName(string name, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetTermTemplateDefByNameAsync(string name, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response GetTypeDefByGuid(string guid, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetTypeDefByGuidAsync(string guid, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response GetTypeDefByName(string name, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetTypeDefByNameAsync(string name, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response GetTypeDefHeaders(bool? includeTermTemplate = default(bool?), string type = null, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetTypeDefHeadersAsync(bool? includeTermTemplate = default(bool?), string type = null, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual Azure.Response UpdateAtlasTypeDefs(Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> UpdateAtlasTypeDefsAsync(Azure.Core.RequestContent requestBody, Azure.RequestOptions requestOptions = null) { throw null; }
    }
}

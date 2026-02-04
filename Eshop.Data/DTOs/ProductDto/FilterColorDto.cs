using Eshop.Data.DTOs.Paging;
using Eshop.Data.DTOs.ProductCategoryDto;
using Eshop.Data.Entities.ProductEntities;

namespace Eshop.Data.DTOs.ProductDto
{
    public class FilterColorDto : BasePaging
    {
        public string Title { get; set; }
        public List<ProductColor> Data { get; set; }

        #region Methods
        public FilterColorDto SetData(List<ProductColor> data)
        {
            Data = data;
            return this;
        }

        public FilterColorDto SetPaging(BasePaging paging)
        {
            PageId = paging.PageId;
            AllEntitiesCount = paging.AllEntitiesCount;
            StartPage = paging.StartPage;
            EndPage = paging.EndPage;
            HowManyShowPageAfterAndBefore = paging.HowManyShowPageAfterAndBefore;
            TakeEntity = paging.TakeEntity;
            SkipEntity = paging.SkipEntity;
            PageCount = paging.PageCount;
            return this;
        }
        #endregion
    }
}

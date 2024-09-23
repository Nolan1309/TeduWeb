using System;
using System.Collections.Generic;
using System.Text;
using TeduWeb.Data.Enums;
using TeduWeb.Data.Interfaces;
using TeduWeb.Infrastructure.SharedKernel;

namespace TeduWeb.Data.Entities
{
    public class ProductCategory : DomainEntity<int>, IHasSeoMetaData, ISwitchable, ISoftTable, IDateTracking
    {
        public ProductCategory()
        {
            Products = new List<Product>();
        }



        public string Name { get; set; }
        public string Description { get; set; }
        public int? ParentId { get; set; }
        public int? HomeOrder { get; set; }
        public string Image { get; set; }
        public bool? HomeFlag { get; set; }


        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int SoftOder { get; set; }
        public Status Status { get; set; }
        public string SeoPageTitle { get; set; }
        public string SeoAlias { get; set; }
        public string SeoKeyWords { get; set; }
        public string SeoDescription { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}

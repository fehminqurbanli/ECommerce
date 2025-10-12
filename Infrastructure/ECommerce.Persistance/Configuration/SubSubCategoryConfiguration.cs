using ECommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Persistance.Configuration
{
    public class SubSubCategoryConfiguration : IEntityTypeConfiguration<SubSubCategory>
    {
        public void Configure(EntityTypeBuilder<SubSubCategory> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(100).IsRequired();
        }
    }
}

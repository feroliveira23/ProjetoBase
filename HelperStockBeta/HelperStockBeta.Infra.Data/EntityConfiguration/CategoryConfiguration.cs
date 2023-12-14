﻿using HelperStockBeta.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HelperStockBeta.Infra.Data.EntityConfiguration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Name).HasMaxLength(100).IsRequired();
            builder.HasData(
                new Category(1, "Material de Escrtório"),
                new Category(2, "Tecnologia e Eletônicos"),
                new Category(3, "Acessorios e Equipamentos")
                );
        }
    }
}

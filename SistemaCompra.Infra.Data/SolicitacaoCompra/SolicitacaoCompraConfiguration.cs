using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaCompra.Infra.Data.SolicitacaoCompra
{
    public class SolicitacaoCompraConfiguration : IEntityTypeConfiguration<SistemaCompra.Domain.SolicitacaoCompraAggregate.SolicitacaoCompra>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<SistemaCompra.Domain.SolicitacaoCompraAggregate.SolicitacaoCompra> builder)
        {
            builder.ToTable("SolicitacaoCompra");
            builder.OwnsOne(x => x.TotalGeral, b => b.Property("Value").HasColumnName("TotalGeral"));
            builder.OwnsOne(x => x.CondicaoPagamento, b => b.Property("Valor").HasColumnName("CondicaoPagamento"));
            builder.OwnsOne(x => x.NomeFornecedor, b => b.Property("Nome").HasColumnName("NomeFornecedor"));
            builder.OwnsOne(x => x.UsuarioSolicitante, b => b.Property("Nome").HasColumnName("UsuarioSolicitante"));
        }
    }
}

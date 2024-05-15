using Microsoft.EntityFrameworkCore;
using SistemaComercioBiblioteca.Classes;
using SistemaComercioLibrary.Classes;
using SistemaComercioLibrary.Entity;

namespace SistemaComercioLibrary.Persistence.Context
{
    //responsavel por fazer a conexao com o banco, chama o entity (framework)
    //DataBaseContext : DbContext -> recebe uma herança dbcontext e referente ao ORM
    public class DataBaseContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var BancoPav = "Server=ec2-34-235-198-25.compute-1.amazonaws.com;Database=d3cnf1jkmj9dk2;User Id=bdgwjotucdayon;Password=6eaa98508e6c97e25ff1b7afe3a2283a5ca85138ba9d4f0faa5de439614b797c; SSL Mode=Require;Trust Server Certificate=true";

            optionsBuilder.UseNpgsql(BancoPav).UseLazyLoadingProxies(); //carrega os relacionamentos automatico
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Produto>()
                .HasOne(produto => produto.Fornecedor)// um produto tem 1 fornecedor
                .WithMany(fornecedor => fornecedor.Produto)// um fornecedor tem mts produtos
                .HasForeignKey(produto => produto.Id_Fornecedor);//aponta pra tabela q ta ligada com a FK

            builder.Entity<ContaPagar>()
                .HasOne(pagar => pagar.Fornecedor)// uma contapagar tem 1 fornecedor
                .WithMany(fornecedor => fornecedor.ContaPagar)// um fornecedor tem mts contaspagar
                .HasForeignKey(pagar => pagar.Id_Fornecedor);//aponta pra tabela q ta ligada com a FK

            builder.Entity<Compra>()
               .HasOne(compra => compra.Fornecedor)// uma compra tem 1 fornecedor
               .WithMany(fornecedor => fornecedor.Compra)// um fornecedor tem mts compras
               .HasForeignKey(compra => compra.Id_Fornecedor);//aponta pra tabela q ta ligada com a FK

            builder.Entity<MovimentoCaixa>()
              .HasOne(movimento => movimento.Caixa)// um movimento tem 1 caixa
              .WithMany(caixa => caixa.MovimentoCaixa)// uma caixa tem mts movimentos
              .HasForeignKey(movimento => movimento.Id_Caixa);//aponta pra tabela q ta ligada com a FK

            builder.Entity<ContaReceber>()
              .HasOne(receber => receber.Cliente)// uma contareceber tem 1 cliente
              .WithMany(caixa => caixa.ContaReceber)// um cliente tem mts contasreceber
              .HasForeignKey(receber => receber.Id_Cliente);//aponta pra tabela q ta ligada com a FK

            builder.Entity<Venda>()
              .HasOne(venda => venda.Cliente)// uma venda tem 1 cliente
              .WithMany(cliente => cliente.Venda)// um cliente tem mts vendas
              .HasForeignKey(venda => venda.Id_Cliente);//aponta pra tabela q ta ligada com a FK

            builder.Entity<FormaPagamentoVenda>()
              .HasOne(formaPagamentoVenda => formaPagamentoVenda.Venda)// uma formaPagamentoVenda tem 1 venda
              .WithMany(venda => venda.FormaPagamentoVenda)// uma venda tem mts formasPagamentoVenda
              .HasForeignKey(formaPagamentoVenda => formaPagamentoVenda.Id_Venda);//aponta pra tabela q ta ligada com a FK

            builder.Entity<FormaPagamentoVenda>()
              .HasOne(formaPagamentoVenda => formaPagamentoVenda.FormaPagamento)// uma formaPagamentoVenda tem 1 formaPagamento
              .WithMany(formaPagamento => formaPagamento.FormaPagamentoVenda)// uma formaPagamento tem mts formasPagamentoVenda
              .HasForeignKey(formaPagamentoVenda => formaPagamentoVenda.Id_FormaPagamento);//aponta pra tabela q ta ligada com a FK

            builder.Entity<ItemVenda>()
              .HasOne(itemVenda => itemVenda.Venda)// um itemVenda tem 1 venda
              .WithMany(venda => venda.ItemVenda)// uma venda tem mts itensVenda
              .HasForeignKey(itemVenda => itemVenda.Id_Venda);//aponta pra tabela q ta ligada com a FK

            builder.Entity<ItemVenda>()
              .HasOne(itemVenda => itemVenda.Produto)// um itemVenda tem 1 produto
              .WithMany(produto => produto.ItemVenda)// um produto tem mts itensVenda
              .HasForeignKey(itemVenda => itemVenda.Id_Produto);//aponta pra tabela q ta ligada com a FK

            builder.Entity<ItemCompra>()
              .HasOne(itemCompra => itemCompra.Produto)// um itemCompra tem 1 produto
              .WithMany(produto => produto.ItemCompra)// um produto tem mts itensCompra
              .HasForeignKey(itemCompra => itemCompra.Id_Produto);//aponta pra tabela q ta ligada com a FK

            builder.Entity<ItemCompra>()
              .HasOne(itemCompra => itemCompra.Compra)// um itemCompra tem 1 compra
              .WithMany(compra => compra.ItemCompra)// uma compra tem mts itensCompra
              .HasForeignKey(itemCompra => itemCompra.Id_Compra);//aponta pra tabela q ta ligada com a FK
        }

        //Atributo referente a tabela no banco
        public DbSet<Adm> Adm { get; set; }
        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<FormaPagamentoVenda> FormaPagamentoVenda { get; set; }
        public DbSet<Caixa> Caixa { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<ContaPagar> ContaPagar { get; set; }
        public DbSet<ContaReceber> ContaReceber { get; set; }
        public DbSet<FormaPagamento> FormaPagamento { get; set; }
        public DbSet<MovimentoCaixa> MovimentoCaixa { get; set; }
        public DbSet<Venda> Venda { get; set; }
        public DbSet<Compra> Compra { get; set; }
        public DbSet<ItemCompra> ItemCompra { get; set; }
        public DbSet<ItemVenda> ItemVenda { get; set; }
    }
}

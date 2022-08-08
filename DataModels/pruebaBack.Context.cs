﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModels
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class PruebaLauraRoaEntities : DbContext
    {
        public PruebaLauraRoaEntities()
            : base("name=PruebaLauraRoaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<sp_CrearCuenta_Result> sp_CrearCuenta(Nullable<int> idCliente, string numeroCuenta, Nullable<decimal> saldo)
        {
            var idClienteParameter = idCliente.HasValue ?
                new ObjectParameter("idCliente", idCliente) :
                new ObjectParameter("idCliente", typeof(int));
    
            var numeroCuentaParameter = numeroCuenta != null ?
                new ObjectParameter("numeroCuenta", numeroCuenta) :
                new ObjectParameter("numeroCuenta", typeof(string));
    
            var saldoParameter = saldo.HasValue ?
                new ObjectParameter("saldo", saldo) :
                new ObjectParameter("saldo", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_CrearCuenta_Result>("sp_CrearCuenta", idClienteParameter, numeroCuentaParameter, saldoParameter);
        }
    
        public virtual ObjectResult<sp_CrearTransaccion_Result> sp_CrearTransaccion(Nullable<int> idCliente, Nullable<int> idCuenta, Nullable<decimal> valor, Nullable<int> idTipoTransaccion)
        {
            var idClienteParameter = idCliente.HasValue ?
                new ObjectParameter("idCliente", idCliente) :
                new ObjectParameter("idCliente", typeof(int));
    
            var idCuentaParameter = idCuenta.HasValue ?
                new ObjectParameter("idCuenta", idCuenta) :
                new ObjectParameter("idCuenta", typeof(int));
    
            var valorParameter = valor.HasValue ?
                new ObjectParameter("valor", valor) :
                new ObjectParameter("valor", typeof(decimal));
    
            var idTipoTransaccionParameter = idTipoTransaccion.HasValue ?
                new ObjectParameter("idTipoTransaccion", idTipoTransaccion) :
                new ObjectParameter("idTipoTransaccion", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_CrearTransaccion_Result>("sp_CrearTransaccion", idClienteParameter, idCuentaParameter, valorParameter, idTipoTransaccionParameter);
        }
    
        public virtual ObjectResult<sp_ObtenerClientes_Result> sp_ObtenerClientes()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ObtenerClientes_Result>("sp_ObtenerClientes");
        }
    
        public virtual ObjectResult<sp_ObtenerCuentas_Result> sp_ObtenerCuentas(Nullable<int> idCliente)
        {
            var idClienteParameter = idCliente.HasValue ?
                new ObjectParameter("idCliente", idCliente) :
                new ObjectParameter("idCliente", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ObtenerCuentas_Result>("sp_ObtenerCuentas", idClienteParameter);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models.PisCofins;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Ninject;
using Hlp.Sped.Infrastructure;
using Hlp.Sped.Repository.Implementation.SQLExpressions.PisCofins;
using Hlp.Sped.Repository.Interfaces.SQLExpressions.PisCofins;
using Hlp.Sped.Repository.Implementation.PisCofins.Mappers;
using Hlp.Sped.Repository.Interfaces.PisCofins;

namespace Hlp.Sped.Repository.Implementation.PisCofins
{
    public class NotasFiscaisServComunicacaoRepository : INotasFiscaisServComunicacaoRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        [Inject]
        public ISqlExpressionsPisCofinsRepository SqlExpressionsPisCofinsRepository { get; set; }

        DataAccessor<RegistroD500> regD500Accessor;
        DataAccessor<RegistroD501> regD501Accessor;
        DataAccessor<RegistroD505> regD505Accessor;

        public IEnumerable<RegistroD010> GetRegistrosD010()
        {
            DataAccessor<RegistroD010> regA010Accessor =
                UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                  SqlExpressionsPisCofinsRepository.GetSelectRegistrosD010(),
                  new FilterByCdEmpresaDtEmiNfParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                  MapBuilder<RegistroD010>.MapAllProperties().Build());
            return regA010Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal).ToList();
        }

        public IEnumerable<RegistroD100> GetRegistroD100(string codEmp)
        {
            DataAccessor<RegistroD100> regD100Accessor =
               UndTrabalho.DBOrigemDadosContmatic.CreateSqlStringAccessor(
                 SqlExpressionsPisCofinsRepository.GetSelectRegistroD100(),
                 new FilterByCdEmpresaDtEmiNfParameterMapper(UndTrabalho.DBOrigemDadosContmatic),
                 MapBuilder<RegistroD100>.MapAllProperties().Build());

            return regD100Accessor.Execute(
                codEmp,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal).ToList();
        }

        public IEnumerable<RegistroD101> GetRegistrosD101(string PK_NOTAFIS, string codEmp)
        {
            DataAccessor<RegistroD101> regD101Accessor =
               UndTrabalho.DBOrigemDadosContmatic.CreateSqlStringAccessor(
                 SqlExpressionsPisCofinsRepository.GetSelectRegistroD101(),
                 new FilterByCdEmpresaPkNotaFisParameterMapper(UndTrabalho.DBOrigemDadosContmatic),
                 MapBuilder<RegistroD101>.MapAllProperties().Build());

            return regD101Accessor.Execute(
                codEmp,
                PK_NOTAFIS).ToList();
        }

        public IEnumerable<RegistroD105> GetRegistrosD105(string PK_NOTAFIS, string codEmp)
        {
            DataAccessor<RegistroD105> regD105Accessor =
               UndTrabalho.DBOrigemDadosContmatic.CreateSqlStringAccessor(
                 SqlExpressionsPisCofinsRepository.GetSelectRegistroD105(),
                 new FilterByCdEmpresaPkNotaFisParameterMapper(UndTrabalho.DBOrigemDadosContmatic),
                 MapBuilder<RegistroD105>.MapAllProperties().Build());

            return regD105Accessor.Execute(
                codEmp,
                PK_NOTAFIS).ToList();
        }


        public IEnumerable<RegistroD500> GetRegistrosD500(string CD_CNPJ, string codEmp)
        {
            IEnumerable<RegistroD500> objRet;
            if (regD500Accessor == null)
                regD500Accessor =
                UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                  SqlExpressionsPisCofinsRepository.GetSelectRegistroD500(),
                  new FilterByCdEmpresaCdCNPJDtEmiNfParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                  MapBuilder<RegistroD500>.MapAllProperties().Build());

            try
            {
                objRet = regD500Accessor.Execute(
               codEmp,
               CD_CNPJ,
               UndTrabalho.DataInicial,
               UndTrabalho.DataFinal);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return objRet;
        }

        public IEnumerable<RegistroD501> GetRegistrosD501(string codChaveNotaFiscal, string codEmp)
        {
            if (regD501Accessor == null)
                regD501Accessor =
                   UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                     SqlExpressionsPisCofinsRepository.GetSelectRegistroD501(),
                     new FilterByCdEmpresaPkNotaFisParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                     MapBuilder<RegistroD501>.MapAllProperties().Build());

            return regD501Accessor.Execute(
                codEmp,
                codChaveNotaFiscal);
        }

        public IEnumerable<RegistroD505> GetRegistrosD505(string codChaveNotaFiscal, string codEmp)
        {
            if (regD505Accessor == null)
                regD505Accessor =
                   UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                     SqlExpressionsPisCofinsRepository.GetSelectRegistroD505(),
                     new FilterByCdEmpresaPkNotaFisParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                     MapBuilder<RegistroD505>.MapAllProperties().Build());

            return regD505Accessor.Execute(
                codEmp,
                codChaveNotaFiscal);
        }

        public IEnumerable<RegistroD200> GetRegistroD200(string codEmp)
        {
            DataAccessor<RegistroD200> regD200Accessor =
               UndTrabalho.DBOrigemDadosContmatic.CreateSqlStringAccessor(
                 SqlExpressionsPisCofinsRepository.GetSelectRegistroD200(),
                 new FilterByCdEmpresaDtEmiNfParameterMapper(UndTrabalho.DBOrigemDadosContmatic),
                 MapBuilder<RegistroD200>.MapAllProperties().Build());

            return regD200Accessor.Execute(
                codEmp,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal).ToList();
        }

        public IEnumerable<RegistroD201> GetRegistrosD201(string PK_NOTAFIS, string codEmp)
        {
            DataAccessor<RegistroD201> regD201Accessor =
               UndTrabalho.DBOrigemDadosContmatic.CreateSqlStringAccessor(
                 SqlExpressionsPisCofinsRepository.GetSelectRegistroD201(),
                 new FilterByCdEmpresaPkNotaFisParameterMapper(UndTrabalho.DBOrigemDadosContmatic),
                 MapBuilder<RegistroD201>.MapAllProperties().Build());

            return regD201Accessor.Execute(
                codEmp,
                PK_NOTAFIS).ToList();
        }

        public IEnumerable<RegistroD205> GetRegistrosD205(string PK_NOTAFIS, string codEmp)
        {
            DataAccessor<RegistroD205> regD205Accessor =
               UndTrabalho.DBOrigemDadosContmatic.CreateSqlStringAccessor(
                 SqlExpressionsPisCofinsRepository.GetSelectRegistroD205(),
                 new FilterByCdEmpresaPkNotaFisParameterMapper(UndTrabalho.DBOrigemDadosContmatic),
                 MapBuilder<RegistroD205>.MapAllProperties().Build());

            return regD205Accessor.Execute(
                codEmp,
                PK_NOTAFIS).ToList();
        }
    }
}

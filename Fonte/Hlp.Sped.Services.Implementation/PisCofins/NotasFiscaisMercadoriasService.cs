﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Hlp.Sped.Services.Interfaces.PisCofins;
using Hlp.Sped.Repository.Interfaces.PisCofins;
using Hlp.Sped.Domain.Models.PisCofins;

namespace Hlp.Sped.Services.Implementation.PisCofins
{
    public class NotasFiscaisMercadoriasService : INotasFiscaisMercadoriasService
    {
        [Inject]
        public INotasFiscaisMercadoriasRepository NotasFiscaisMercadoriasRepository { get; set; }

        public IEnumerable<RegistroC100> GetRegistrosC100(string codCNPJ)
        {
            return NotasFiscaisMercadoriasRepository.GetRegistrosC100(codCNPJ);
        }

        public IEnumerable<RegistroC120> GetRegistrosC120(string codChaveNotaFiscal)
        {
            return NotasFiscaisMercadoriasRepository.GetRegistrosC120(codChaveNotaFiscal);
        }

        public IEnumerable<RegistroC170> GetRegistrosC170(string codChaveNotaFiscal)
        {
            return NotasFiscaisMercadoriasRepository.GetRegistrosC170(codChaveNotaFiscal);
        }
    }
}
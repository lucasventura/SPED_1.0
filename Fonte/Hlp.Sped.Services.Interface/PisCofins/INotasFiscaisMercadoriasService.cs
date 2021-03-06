﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models.PisCofins;

namespace Hlp.Sped.Services.Interfaces.PisCofins
{
    public interface INotasFiscaisMercadoriasService
    {
        IEnumerable<RegistroC100> GetRegistrosC100(string codCNPJ, string codEmp);
        IEnumerable<RegistroC120> GetRegistrosC120(string codChaveNotaFiscal, string codEmp);
        IEnumerable<RegistroC170> GetRegistrosC170(string codChaveNotaFiscal, string codEmp);
    }
}
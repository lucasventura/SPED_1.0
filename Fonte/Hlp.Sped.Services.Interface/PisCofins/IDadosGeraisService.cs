﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models.PisCofins;

namespace Hlp.Sped.Services.Interfaces.PisCofins
{
    public interface IDadosGeraisService
    {
        Registro0000 GetRegistro0000();
        Registro0001 GetRegistro0001();
        Registro0100 GetRegistro0100();
        Registro0110 GetRegistro0110();
        Registro0140 GetRegistro0140();
        IEnumerable<Registro0400> GetRegistro0400();
        IEnumerable<Registro0500> GetRegistro0500();
    }
}
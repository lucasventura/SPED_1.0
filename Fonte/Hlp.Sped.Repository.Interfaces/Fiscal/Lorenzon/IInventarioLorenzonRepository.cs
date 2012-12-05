﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models.Fiscal;
using Hlp.Sped.Domain.Models.Fiscal.Lorenzon;

namespace Hlp.Sped.Repository.Interfaces.Fiscal.Lorenzon
{
    public interface IInventarioLorenzonRepository
    {
        IEnumerable<RegistroH005Lorenzon> GetRegistrosH005();
        IEnumerable<RegistroH010> GetRegistrosH010(DateTime dataInventario);
        IEnumerable<Registro0200> GetRegistros0200();
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Ninject.Modules;
using Hlp.Sped.Infrastructure.Controllers;
using Hlp.Sped.Controllers.IoC.Fiscal;
using Hlp.Sped.Services.Interfaces.Fiscal;
using Hlp.Sped.Domain.Models;

namespace Hlp.Sped.Controllers.Fiscal
{
    public class FrontController : BaseController
    {
        [Inject]
        public IEmpresasService EmpresasService { get; set; }

        protected override NinjectModule GetInstanceDIControllersModule()
        {
            DIContollersModuleFront module = new DIContollersModuleFront();
            return module;
        }

        public IEnumerable<Empresa> ListEmpresasDisponiveis()
        {
            return EmpresasService.ListAll();
        }
    }
}

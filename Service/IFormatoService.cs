﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace Service
{
   public interface IFormatoService
    {
       IEnumerable<Formato> Getformatos();
    }
}

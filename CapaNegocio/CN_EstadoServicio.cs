﻿using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_EstadoServicio
    {
        private CD_EstadoServicio oCD_EstadoServ = new CD_EstadoServicio();
        public List<EstadoServicio> Listar()
        {
            return oCD_EstadoServ.Listar();
        }
    }
}

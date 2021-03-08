﻿using AppVacunas.Server.DTOs.Direccion;
using AppVacunas.Server.DTOs.Pais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppVacunas.Server.DTOs {
    public class ProvinciaDTO : ProvinciaCreacionDTO {
        public int Id { get; set; }
        public virtual PaisDTO Pais { get; set; }
        public virtual ICollection<DireccionDTO> Direcciones { get; set; }
    }
}
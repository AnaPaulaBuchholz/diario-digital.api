﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace diario_digital.api.Controllers
{
    [ApiController]
    [Route("usuarios")]
    public class UsuarioController : ControllerBase
    {
        [Route("{Id}")]
        public async Task<IActionResult> ObterUsuario([FromRoute] Guid Id)
        {
            throw new NotImplementedException();
        }
    }
}

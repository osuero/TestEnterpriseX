using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.XEnterprise.Mappers
{
    public class PermissionTypeDto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public ICollection<PermissionDto> Permissions { get; set; }
    }
}

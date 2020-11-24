using System;

namespace Api.XEnterprise.Mappers
{
    public class PermissionDto
    {
        public int Id { get; set; }
        public string NombreEmpleado { get; set; }
        public string ApellidosEmpleado { get; set; }
        public DateTime FechaPermiso { get; set; }

        public int TipoPermiso { get; set; }
        public PermissionTypeDto PermissionType { get; set; }
    }
}

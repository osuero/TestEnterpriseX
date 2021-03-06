﻿using Api.Data.CommonEntitiesProperty;
using System.Collections.Generic;

namespace Api.Data.Entities
{
    public class PermissionType: GenericEntity
    {
        public string Descripcion { get; set; }
        public ICollection<Permission> Permissions { get; set; }
    }
}

﻿namespace TraversalCoreProje.Areas.Admin.Models
{
    public class RoleAssignViewModel
    {
        public int RoleID { get; set; }
        public string RoleName  { get; set; }
        public bool RoleExist { get; set; } //Bu rol bu kullanıcıda varmı sorusunun cevabını almak için tanımladığımız property.
    }
}
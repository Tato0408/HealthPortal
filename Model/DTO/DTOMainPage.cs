using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthPortal.Model.DTO
{
    internal class DTOMainPage : dbContext
    {
        private string institutionName;

        public string InstitutionName { get => institutionName; set => institutionName = value; }
    }
}

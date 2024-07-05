using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapYorum.Entites.EntityConfigs
{
    internal class BaseConfig<T> : IEntityTypeConfiguration<T> where T : BaseEntity 
    {
    }
}

﻿using _14_Firma.FirmaEntities.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Firma.FirmaEntities.EntityConfig.Abstract
{
        public abstract class BaseConfig<T> : IEntityTypeConfiguration<T> where T : BaseEntity
        {
            public virtual void Configure(EntityTypeBuilder<T> builder)
            {
                builder.HasKey(x => x.Id);
            }
        }
    }
}

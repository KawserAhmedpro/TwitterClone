using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Infrastructure.Persistence.Configurations
{
    public  class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            // Configuration logic for the User entity
            builder.HasKey(u => u.Id);
            builder.Property(u => u.FirstName )
                .IsRequired()
               ;
            builder.Property(u => u.LastName )
                .IsRequired()
               ;
            builder.Property(u => u.Email)
                .IsRequired();
            builder .Property(u => u.PasswordHash)
                .IsRequired();

            builder.HasIndex(u => u.Email)
                .IsUnique();        

        }
    }
}

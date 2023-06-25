using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.web.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "674513af-5dd6-1d51-b63c-46c24a668f27",
                    UserId = "98041755-041b-471b-83c7-0d2b73223833"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "974513aa-5dd6-1d51-b63a-46c24a668f27",
                    UserId = "88041755-041a-471c-83c7-0d2a73223832"
                }
                );
        }
    }
}
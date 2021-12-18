using DotNet6.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotNet6.Configuration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(c => c.FullName)
                .HasComputedColumnSql("[LastName] + ', ' + [FirstName]");

            builder.Property(c => c.DateOfBirth)
               .HasComputedColumnSql("Convert(date, [Birthday])");

            builder.Property(c => c.TimeOfBirth)
               .HasComputedColumnSql("SELECT CONVERT(VARCHAR(8),[Birthday],108)");

            builder.Property(c => c.CashIfWonLottery)
                .HasComputedColumnSql("[Age] * 100", true);

            builder.Ignore(c => c.DateOfBirth);
            builder.Ignore(c => c.TimeOfBirth);
        }
    }
}

// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

namespace League.Model
{

    // hba_draw
    [System.CodeDom.Compiler.GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.19.1.0")]
    public class DrawConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Draw>
    {
        public DrawConfiguration()
            : this("dbo")
        {
        }
 
        public DrawConfiguration(string schema)
        {
            ToTable(schema + ".hba_draw");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.TeamId).HasColumnName("team_id").IsRequired().HasColumnType("int");
            Property(x => x.WeekId).HasColumnName("week_id").IsRequired().HasColumnType("int");
            Property(x => x.Lane).HasColumnName("lane").IsRequired().HasColumnType("int");
            Property(x => x.Pairing).HasColumnName("pairing").IsRequired().HasColumnType("int");
            Property(x => x.Game1).HasColumnName("game_1").IsRequired().HasColumnType("int");
            Property(x => x.Game2).HasColumnName("game_2").IsRequired().HasColumnType("int");
            Property(x => x.Game3).HasColumnName("game_3").IsRequired().HasColumnType("int");
            Property(x => x.Series).HasColumnName("series").IsRequired().HasColumnType("int");
            Property(x => x.Bonus).HasColumnName("bonus").IsRequired().HasColumnType("int");
            Property(x => x.Total).HasColumnName("total").IsRequired().HasColumnType("int");
            Property(x => x.LegalLineup).HasColumnName("legal_lineup").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);

            // Foreign keys
            HasRequired(a => a.Team).WithMany(b => b.Draws).HasForeignKey(c => c.TeamId); // hba_draw_fk2
            HasRequired(a => a.Week).WithMany(b => b.Draws).HasForeignKey(c => c.WeekId); // hba_draw_fk1
        }
    }

}
// </auto-generated>

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

    // hba_v_draw
    [System.CodeDom.Compiler.GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.19.1.0")]
    public class VdrawConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Vdraw>
    {
        public VdrawConfiguration()
            : this("dbo")
        {
        }
 
        public VdrawConfiguration(string schema)
        {
            ToTable(schema + ".hba_v_draw");
            HasKey(x => new { x.Season, x.Round, x.Lane, x.TeamName, x.Game1, x.Game2, x.Game3, x.Series, x.Bonus, x.Total, x.WeekId, x.Id, x.TeamId });

            Property(x => x.Season).HasColumnName("season").IsRequired().HasColumnType("int");
            Property(x => x.Round).HasColumnName("round").IsRequired().HasColumnType("int");
            Property(x => x.RoundWeek).HasColumnName("round_week").IsOptional().HasColumnType("int");
            Property(x => x.Lane).HasColumnName("lane").IsRequired().HasColumnType("int");
            Property(x => x.TeamName).HasColumnName("team_name").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(30);
            Property(x => x.Game1).HasColumnName("game_1").IsRequired().HasColumnType("int");
            Property(x => x.Game2).HasColumnName("game_2").IsRequired().HasColumnType("int");
            Property(x => x.Game3).HasColumnName("game_3").IsRequired().HasColumnType("int");
            Property(x => x.Series).HasColumnName("series").IsRequired().HasColumnType("int");
            Property(x => x.Bonus).HasColumnName("bonus").IsRequired().HasColumnType("int");
            Property(x => x.Total).HasColumnName("total").IsRequired().HasColumnType("int");
            Property(x => x.LegalLineup).HasColumnName("legal_lineup").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
            Property(x => x.WeekId).HasColumnName("week_id").IsRequired().HasColumnType("int");
            Property(x => x.Id).HasColumnName("id").IsRequired().HasColumnType("int");
            Property(x => x.TeamId).HasColumnName("team_id").IsRequired().HasColumnType("int");
        }
    }

}
// </auto-generated>

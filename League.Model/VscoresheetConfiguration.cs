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

    // hba_v_scoresheet
    [System.CodeDom.Compiler.GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.19.1.0")]
    public class VscoresheetConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Vscoresheet>
    {
        public VscoresheetConfiguration()
            : this("dbo")
        {
        }
 
        public VscoresheetConfiguration(string schema)
        {
            ToTable(schema + ".hba_v_scoresheet");
            HasKey(x => new { x.WeekId, x.Season, x.Round, x.Lane, x.TeamId, x.TeamName, x.BowlerId, x.BowlerName, x.BlindScore, x.Handicap, x.Game1, x.Game2, x.Game3 });

            Property(x => x.WeekId).HasColumnName("week_id").IsRequired().HasColumnType("int");
            Property(x => x.Season).HasColumnName("season").IsRequired().HasColumnType("int");
            Property(x => x.Round).HasColumnName("round").IsRequired().HasColumnType("int");
            Property(x => x.RoundWeek).HasColumnName("round_week").IsOptional().HasColumnType("int");
            Property(x => x.Lane).HasColumnName("lane").IsRequired().HasColumnType("int");
            Property(x => x.TeamId).HasColumnName("team_id").IsRequired().HasColumnType("int");
            Property(x => x.TeamName).HasColumnName("team_name").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(30);
            Property(x => x.BowlerId).HasColumnName("bowler_id").IsRequired().HasColumnType("int");
            Property(x => x.BowlerName).HasColumnName("bowler_name").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(30);
            Property(x => x.BlindScore).HasColumnName("blind_score").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
            Property(x => x.Handicap).HasColumnName("handicap").IsRequired().HasColumnType("int");
            Property(x => x.Game1).HasColumnName("game_1").IsRequired().HasColumnType("int");
            Property(x => x.Game2).HasColumnName("game_2").IsRequired().HasColumnType("int");
            Property(x => x.Game3).HasColumnName("game_3").IsRequired().HasColumnType("int");
            Property(x => x.ScratchSeries).HasColumnName("scratch_series").IsOptional().HasColumnType("int");
            Property(x => x.HandicappedSeries).HasColumnName("handicapped_series").IsOptional().HasColumnType("int");
        }
    }

}
// </auto-generated>

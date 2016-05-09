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

    // hba_v_individual_game
    [System.CodeDom.Compiler.GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.19.1.0")]
    public class VindividualgameConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Vindividualgame>
    {
        public VindividualgameConfiguration()
            : this("dbo")
        {
        }
 
        public VindividualgameConfiguration(string schema)
        {
            ToTable(schema + ".hba_v_individual_game");
            HasKey(x => new { x.Season, x.WeekNumber, x.BowlerId, x.Handicap, x.Game, x.Game1, x.DrawId });

            Property(x => x.Season).HasColumnName("season").IsRequired().HasColumnType("int");
            Property(x => x.WeekNumber).HasColumnName("week_number").IsRequired().HasColumnType("int");
            Property(x => x.BowlerId).HasColumnName("bowler_id").IsRequired().HasColumnType("int");
            Property(x => x.Handicap).HasColumnName("handicap").IsRequired().HasColumnType("int");
            Property(x => x.Game).HasColumnName("game").IsRequired().HasColumnType("int");
            Property(x => x.Game1).HasColumnName("game_1").IsRequired().HasColumnType("int");
            Property(x => x.DrawId).HasColumnName("draw_id").IsRequired().HasColumnType("int");
        }
    }

}
// </auto-generated>

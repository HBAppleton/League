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

    // hba_v_RollingAverage
    [System.CodeDom.Compiler.GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.19.1.0")]
    public class VRollingAverageConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<VRollingAverage>
    {
        public VRollingAverageConfiguration()
            : this("dbo")
        {
        }
 
        public VRollingAverageConfiguration(string schema)
        {
            ToTable(schema + ".hba_v_RollingAverage");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasColumnType("int");
            Property(x => x.SeriesAverage).HasColumnName("series_average").IsOptional().HasColumnType("int");
        }
    }

}
// </auto-generated>

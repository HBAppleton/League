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

    // hba_team_note
    [System.CodeDom.Compiler.GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.19.1.0")]
    public class Teamnote: Entity<int>
    {
        public int Id { get; set; } // id (Primary key)
        public int TeamId { get; set; } // team_id
        public int Season { get; set; } // season
        public string Note { get; set; } // note
        public int? Rank { get; set; } // rank

        // Foreign keys
        public virtual Team Team { get; set; } // hba_team_note_fk1
    }

}
// </auto-generated>

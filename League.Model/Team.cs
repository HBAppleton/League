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

    // hba_team
    [System.CodeDom.Compiler.GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.19.1.0")]
    public class Team: Entity<int>
    {
        public int Id { get; set; } // id (Primary key)
        public string TeamName { get; set; } // team_name (length: 30)
        public int? RoundWinner { get; set; } // round_winner
        public string ActiveFlag { get; set; } // active_flag (length: 1)

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<Bowler> Bowlers { get; set; } // hba_bowler.hba_bowler_fk1
        public virtual System.Collections.Generic.ICollection<Draw> Draws { get; set; } // hba_draw.hba_draw_fk2
        public virtual System.Collections.Generic.ICollection<Teamnote> Teamnotes { get; set; } // hba_team_note.hba_team_note_fk1
        
        public Team()
        {
            Bowlers = new System.Collections.Generic.List<Bowler>();
            Draws = new System.Collections.Generic.List<Draw>();
            Teamnotes = new System.Collections.Generic.List<Teamnote>();
        }
    }

}
// </auto-generated>

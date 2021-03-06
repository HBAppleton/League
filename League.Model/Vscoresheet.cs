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
    public class Vscoresheet: Entity<int>
    {
        public int WeekId { get; set; } // week_id
        public int Season { get; set; } // season
        public int Round { get; set; } // round
        public int? RoundWeek { get; set; } // round_week
        public int Lane { get; set; } // lane
        public int TeamId { get; set; } // team_id
        public string TeamName { get; set; } // team_name (length: 30)
        public int BowlerId { get; set; } // bowler_id
        public string BowlerName { get; set; } // bowler_name (length: 30)
        public string BlindScore { get; set; } // blind_score (length: 1)
        public int Handicap { get; set; } // handicap
        public int Game1 { get; set; } // game_1
        public int Game2 { get; set; } // game_2
        public int Game3 { get; set; } // game_3
        public int? ScratchSeries { get; set; } // scratch_series
        public int? HandicappedSeries { get; set; } // handicapped_series
    }

}
// </auto-generated>

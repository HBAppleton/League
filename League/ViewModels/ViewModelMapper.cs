using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using League.Model;

namespace League.ViewModels
{
    public class ViewModelMapper
    {
        public BowlerViewModel BowlerToVM(Bowler bowler)
        {
            BowlerViewModel vm = new BowlerViewModel();

            vm.Id = bowler.Id;
            vm.BowlerName = bowler.BowlerName;
            vm.Address = bowler.Address;
            vm.Email = bowler.Email;
            vm.Phone = bowler.Phone;
            vm.Gender = bowler.Gender;
            vm.ActiveFlag = bowler.ActiveFlag;
            vm.PrivacyFlag = bowler.PrivacyFlag;
            vm.TeamId = bowler.TeamId;
            vm.Position = bowler.Position;

            return vm;
        }

        public Bowler BowlerFromVM(BowlerViewModel vm)
        {
            Bowler bowler = new Bowler();

            bowler.Id = vm.Id;
            bowler.BowlerName = vm.BowlerName;
            bowler.Address = vm.Address;
            bowler.Email = vm.Email;
            bowler.Phone = vm.Phone;
            bowler.Gender = vm.Gender;
            bowler.ActiveFlag = vm.ActiveFlag;
            bowler.PrivacyFlag = vm.PrivacyFlag;
            bowler.TeamId = vm.TeamId;
            bowler.Position = vm.Position;

            return bowler;
        }

        public BowlerNoteViewModel BowlerNoteToMV(Bowlernote bowlernote)
        {
            BowlerNoteViewModel vm = new BowlerNoteViewModel();

            vm.Id = bowlernote.Id;
            vm.BowlerId = bowlernote.BowlerId;
            vm.Season = bowlernote.Season;
            vm.Note = bowlernote.Note;
            vm.Rank = bowlernote.Rank;

            return vm;
        }

        public Bowlernote BowlerNoteFromVM(BowlerNoteViewModel vm)
        {
            Bowlernote bowlernote = new Bowlernote();

            bowlernote.Id = vm.Id;
            bowlernote.BowlerId = vm.BowlerId;
            bowlernote.Season = vm.Season;
            bowlernote.Rank = vm.Rank;
            bowlernote.Note = vm.Note;

            return bowlernote;
        }

        public DrawViewModel DrawToVM(Draw draw)
        {
            DrawViewModel vm = new DrawViewModel();

            vm.Id = draw.Id;
            vm.TeamId = draw.TeamId;
            vm.WeekId = draw.WeekId;
            vm.Lane = draw.Lane;
            vm.Pairing = draw.Pairing;
            vm.Game1 = draw.Game1;
            vm.Game2 = draw.Game2;
            vm.Game3 = draw.Game3;
            vm.Series = draw.Series;
            vm.Bonus = draw.Bonus;
            vm.Total = draw.Total;
            vm.LegalLineup = draw.LegalLineup;

            return vm;
        }

        public Draw DrawFromVM(DrawViewModel vm)
        {
            Draw draw = new Draw();

            draw.Id = vm.Id;
            draw.TeamId = vm.TeamId;
            draw.WeekId = vm.WeekId;
            draw.Lane = vm.Lane;
            draw.Pairing = vm.Pairing;
            draw.Game1 = vm.Game1;
            draw.Game2 = vm.Game2;
            draw.Game3 = vm.Game3;
            draw.Series = vm.Series;
            draw.Bonus = vm.Bonus;
            draw.Total = vm.Total;
            draw.LegalLineup = vm.LegalLineup;

            return draw;
        }

        public ScoresheetViewModel ScoresheetToVM(Scoresheet scoresheet)
        {
            ScoresheetViewModel vm = new ScoresheetViewModel();

            vm.Id = scoresheet.Id;
            vm.BowlerId = scoresheet.BowlerId;
            vm.DrawId = scoresheet.DrawId;
            vm.BlindScore = scoresheet.BlindScore;
            vm.Handicap = scoresheet.Handicap;
            vm.Game1 = scoresheet.Game1;
            vm.Game2 = scoresheet.Game2;
            vm.Game3 = scoresheet.Game3;

            return vm;
        }

        public Scoresheet ScoresheetFromVM(ScoresheetViewModel vm)
        {
            Scoresheet scoresheet = new Scoresheet();

            scoresheet.Id = vm.Id;
            scoresheet.BowlerId = vm.BowlerId;
            scoresheet.DrawId = vm.DrawId;
            scoresheet.BlindScore = vm.BlindScore;
            scoresheet.Handicap = vm.Handicap;
            scoresheet.Game1 = vm.Game1;
            scoresheet.Game2 = vm.Game2;
            scoresheet.Game3 = vm.Game3;

            return scoresheet;
        }

        public TeamViewModel TeamToVM(Team team)
        {
            TeamViewModel vm = new TeamViewModel();

            vm.Id = team.Id;
            vm.TeamName = team.TeamName;
            vm.RoundWinner = team.RoundWinner;
            vm.ActiveFlag = team.ActiveFlag;

            return vm;
        }

        public Team TeamFromVM(TeamViewModel vm)
        {
            Team team = new Team();

            team.Id = vm.Id;
            team.TeamName = vm.TeamName;
            team.RoundWinner = vm.RoundWinner;
            team.ActiveFlag = vm.ActiveFlag;

            return team;
        }

        public TeamNoteViewModel TeamNoteToVM(Teamnote teamnote)
        {
            TeamNoteViewModel vm = new TeamNoteViewModel();

            vm.Id = teamnote.Id;
            vm.TeamId = teamnote.TeamId;
            vm.Season = teamnote.Season;
            vm.Note = teamnote.Note;
            vm.Rank = teamnote.Rank;

            return vm;
        }

        public Teamnote TeamNoteFromVM(TeamNoteViewModel vm)
        {
            Teamnote teamnote = new Teamnote();

            teamnote.Id = vm.Id;
            teamnote.TeamId = vm.TeamId;
            teamnote.Season = vm.Season;
            teamnote.Note = vm.Note;
            teamnote.Rank = vm.Rank;

            return teamnote;
        }
    }
}
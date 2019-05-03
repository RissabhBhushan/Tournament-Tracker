using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        public void CreatePrize(PrizeModel model)
        {
            //Load the text file and convert the text to List<PrizeModel>
            List<PrizeModel> prizes = GlobalConfig.PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModel();

            //Find the max Id
            int currentId = 1;
            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            //Add the new record  with the new Id (max + 1)
            prizes.Add(model);

            //Convert the prizes to list<string> and Save the list<string> to the text file
            prizes.SaveToPrizeFile();
        }

        public void CreatePerson(PersonModel model)
        {
            List<PersonModel> person = GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModel();

            int currentId = 1;
            if (person.Count > 0)
            {
                currentId = person.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            person.Add(model);

            person.SaveToPeopleFile();
        }

        public List<PersonModel> GetPerson_All()
        {
            return GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModel();
        }

        public void CreateTeam(TeamModel model)
        {
            List<TeamModel> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModel();

            int currentId = 1;
            if (teams.Count > 0)
            {
                currentId = teams.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            teams.Add(model);

            teams.SaveToTeamFile();
        }

        public List<TeamModel> GetTeam_All()
        {
            return GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModel();
        }

        public void CreateTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = GlobalConfig.TournamentFile.FullFilePath().LoadFile().ConvertToTournamentModel();

            int currentId = 1;
            if (tournaments.Count > 0)
            {
                currentId = tournaments.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            model.SaveRoundToFile();

            tournaments.Add(model);

            tournaments.SaveToTournamentFile();

            TournamentLogic.UpdateTournamentResults(model);
        }

        public List<TournamentModel> GetTournaments_All()
        {
            return GlobalConfig.TournamentFile.FullFilePath().LoadFile().ConvertToTournamentModel();
        }

        public void UpdateMatchup(MatchupModel model)
        {
            model.UpdateMatchupToFile();
        }

        public void CompleteTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = GlobalConfig.TournamentFile.FullFilePath().LoadFile().ConvertToTournamentModel();
            
            tournaments.Remove(model);

            tournaments.SaveToTournamentFile();

            TournamentLogic.UpdateTournamentResults(model);
        }
    }
}

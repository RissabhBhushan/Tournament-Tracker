using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        public int Id { get; set; }

        /// <summary>
        /// Represent one team in the matchup.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        public int TeamCompetingId { get; set; }

        /// <summary>
        /// Represents the score forthis particular team.
        /// </summary>
        public double Score { get; set; }

        public int ParentMatchupId{ get; set; }

        /// <summary>
        /// Represents the matchup this team came from as the winner.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}

using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Square.Http.Client;
using Square;
using Square.Utilities;

namespace Square.Models
{
    public class RetrieveTeamMemberResponse 
    {
        public RetrieveTeamMemberResponse(Models.TeamMember teamMember = null,
            IList<Models.Error> errors = null)
        {
            TeamMember = teamMember;
            Errors = errors;
        }

        [JsonIgnore]
        public HttpContext Context { get; internal set; }

        /// <summary>
        /// A record representing an individual team member for a business.
        /// </summary>
        [JsonProperty("team_member", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TeamMember TeamMember { get; }

        /// <summary>
        /// The errors that occurred during the request.
        /// </summary>
        [JsonProperty("errors", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Models.Error> Errors { get; }

        public Builder ToBuilder()
        {
            var builder = new Builder()
                .TeamMember(TeamMember)
                .Errors(Errors);
            return builder;
        }

        public class Builder
        {
            private Models.TeamMember teamMember;
            private IList<Models.Error> errors;



            public Builder TeamMember(Models.TeamMember teamMember)
            {
                this.teamMember = teamMember;
                return this;
            }

            public Builder Errors(IList<Models.Error> errors)
            {
                this.errors = errors;
                return this;
            }

            public RetrieveTeamMemberResponse Build()
            {
                return new RetrieveTeamMemberResponse(teamMember,
                    errors);
            }
        }
    }
}
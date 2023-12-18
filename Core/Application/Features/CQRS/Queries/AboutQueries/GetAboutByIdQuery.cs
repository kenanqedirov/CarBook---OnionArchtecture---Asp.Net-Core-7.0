using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRS.Queries.AboutQueries
{
    public class GetAboutByIdQuery
    {
        public int id { get; set; }

        public GetAboutByIdQuery(int id)
        {
            this.id = id;
        }
    }
}

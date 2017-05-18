using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Companies;
using Grpc.Core;

namespace CompanyService
{
    public class CompaniesServerImpl : Companies.Companies.CompaniesBase
    {
        private List<GetCompanyByPermalinkResp> resps;

        public CompaniesServerImpl()
        {
            TheCompany = new Company
            {
                Name = "Namely",
                Uuid = Guid.NewGuid().ToString()
            };

            resps = new List<GetCompanyByPermalinkResp>
            {
                new GetCompanyByPermalinkResp
                {
                    Company = TheCompany
                }
            };
        }

        public Company TheCompany { get; set; }

        public override Task<GetCompanyByPermalinkResp> GetCompanyByPermalink(GetCompanyByPermalinkReq request,
            ServerCallContext context)
        {
            return Task.FromResult(resps.FirstOrDefault());
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Sessions;

namespace SessionsServer
{
    public class SessionsServerImpl : Sessions.Sessions.SessionsBase
    {
        private readonly List<GetSessionResp> resps;
        private static Session TheSession { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public SessionsServerImpl()
        {
            TheSession = new Session
            {
                SessionId = "12321",
                UserUuid = "ea153a5b-8c64-4943-9689-3f685381f21c"
            };


            var map = new Dictionary<string, string>();
            map.Add("GL.UserEmail", "kevin@namely.com");
            map.Add("GL.CurrentSubsidiary", "74206F43-71E9-4282-8F91-823886B13AD5");
            map.Add("GL.CompanyUuid", "74206F43-71E9-4282-8F91-823886B13AD5");
            TheSession.Vars.Add(map);

            resps = new List<GetSessionResp>
            {
                new GetSessionResp
                {
                    Session = TheSession
                }
            };
        }

        public override Task<GetSessionResp> GetSession(GetSessionReq request, ServerCallContext context)
        {
            // if (request.SessionId == "Dummy-session-id")
            return Task.FromResult(resps.FirstOrDefault());
            //return Task.FromResult(new GetSessionResp
            //    {
            //        Error = new Error
            //        {
            //            Key = "kevin",
            //            Message = "Kevin error"
            //        }
            //    }
            //);
            //else
            //{
            //    return null;
            //}
        }

        public override Task<SetSessionVarsResp> SetSessionVars(SetSessionVarsReq request, ServerCallContext context)
        {
            TheSession.Vars.Add(request.Vars);
            var response = new SetSessionVarsResp
            {
                Success = true
                //Error = new Error
                //{
                //    Key = "kevin",
                //    Message = "Kevin error"
                //}
            };
            return Task.FromResult(response);
        }
    }
}
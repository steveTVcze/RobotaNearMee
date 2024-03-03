using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotaNearMe.Lib
{
    public class Endpoints
    {
        public static class V1
        {
            public const string GETOFFERS = "api/v1/getjoboffers";
            public const string GETJOBFIELDS = "api/v1/getjobfields";
            public const string GETUSERS = "api/v1/getusers";
            public const string POSTUSER = "api/v1/postuser";
            public const string POSTOFFERINUSER = "api/v1/postofferinuser";
            public const string POSTCONTACT = "api/v1/postcontact";
            public const string POSTEDU = "api/v1/postedu";
            public const string POSTCOMPANY = "api/v1/postcompannyy";
            public const string POSTJOBOFFER = "api/v1/postjoboffer";
            public const string POSTCOMPANYCONTACT = "api/v1/postcompanycontact";
            public const string GETUSERBYNAME = "api/v1/getuserbyname";
            public const string GETCOMPANY = "api/v1/getcompany";
            public const string GETCOMPANYBYCOMPANYID = "api/v1/getcompanybyuserid";
        }
    }
}

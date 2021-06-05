using System.Collections.Generic;
using System.Linq;

namespace Weather.Contracts
{
    public static class ApiRoutes
    {
        public const string Root = "api";
        public const string Version = "v1";
        public const string Base = Root + "/" + Version;

        public static class Posts
        {
            public const string GetAll = Base +"/posts";
        }
        public static class Weather
        {
            public const string Get = Base +"/weather";
        }
        
    }
}
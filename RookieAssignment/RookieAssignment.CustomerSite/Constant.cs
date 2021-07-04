using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RookieAssignment.CustomerSite
{
    public static class Constant
    {
        public static string APIBaseURL = "https://localhost:44347/";
        public static string categoryAPIPath = APIBaseURL + "api/category";
        public static string menuItemAPIPath = APIBaseURL + "api/menuitem";
        public static string menuItemCommentAPIPath = APIBaseURL + "api/menuitemcomment";
    }
}

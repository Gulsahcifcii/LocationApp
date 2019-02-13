using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocationApp.Web.Mvc.Helpers
{
    public class Helper
    {
        private const string Success = "İşlem Başarılı  !";
        private const string UnSuccess = "İşlem Başarısız !";
        public static string GetResultMessage(bool status)
        {
            string message = "";
            if (status)
                message = "<div class='alert alert-success' role='alert'>" + Success + "</div>";
            else
                message = "<div class='alert alert-danger' role='alert'>" + UnSuccess + "</div>";
            return message;
        }
    }
}
﻿using System;
using System.Net;
using Sooduskorv_MVC.Aids.Logging;

namespace Sooduskorv_MVC.Aids.Services {

    public static class WebService {

        public static string Load(string url) {
            var num = 0;

            while (num <= 3) {
                num++;
                using var client = new WebClient();

                try { return client.DownloadString(url); }
                catch (Exception e) { Log.Exception(e); }
            }

            return string.Empty;
        }

    }

}
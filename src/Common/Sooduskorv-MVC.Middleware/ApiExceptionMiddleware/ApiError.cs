﻿namespace Sooduskorv_MVC.Middleware.ApiExceptionMiddleware
{
    public class ApiError
    { 
        public string Id { get; set; }
        public short Status { get; set; }
        public string Code { get; set; }
        public string Links { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
    }
}// leisin parema lahenduse. kirjutan selle kohe siia
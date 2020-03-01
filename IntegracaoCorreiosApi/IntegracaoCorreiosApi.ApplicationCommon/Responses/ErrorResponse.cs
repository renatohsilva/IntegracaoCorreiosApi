﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace IntegracaoCorreiosApi.ApplicationCommon.Responses
{
    public class ErrorResponse
    {
        public IEnumerable<string> Errors { get; set; }

        public ErrorResponse(IEnumerable<string> errors)
        {
            Errors = errors;
        }

        public ErrorResponse(string error)
        {
            Errors = new List<string>()
            {
                error
            };
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(new { errors = Errors });
        }
    }
}

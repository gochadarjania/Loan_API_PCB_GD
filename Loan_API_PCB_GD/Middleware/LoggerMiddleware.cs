using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loan_API_PCB_GD.Middleware
{
    public class LoggerMiddleware
    {

        private readonly RequestDelegate _next;
        private readonly ILoggerFactory _loggerFactory;
        public LoggerMiddleware(RequestDelegate next, ILoggerFactory loggerFactory)
        {
            _next = next;
            _loggerFactory = loggerFactory;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var _logger = _loggerFactory.CreateLogger<LoggerMiddleware>();

            try
            {
                _logger.LogInformation("Performing file logging in Middleware operation");

                // Perform some Database action into Middleware 


                _logger.LogWarning("Performing Middleware Save operation");

                //Save Data


                _logger.LogInformation("Save Comepleted");

                await _next(context);

            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong: {ex.Message}");
            }
        }
    }
}

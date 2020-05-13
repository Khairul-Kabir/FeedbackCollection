﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Cors;
using System.Web.Http.Cors;

namespace FeedbackCollection.CustomPolicies
{
    public class CustomCorsPolicyAttribute: Attribute, ICorsPolicyProvider

    {
        private CorsPolicy _policy;
        public CustomCorsPolicyAttribute()
        {
            _policy = new CorsPolicy
            {
                AllowAnyMethod = true,
                AllowAnyHeader = true
            };
            _policy.Origins.Add("https://localhost:44308");
        }
        public Task<CorsPolicy> GetCorsPolicyAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_policy);
        }
    }
}
﻿using System;
using NUnit.Framework;

namespace Cronofy.Test.CronofyAccountClientTests
{
    internal sealed class GetAccount : Base
    {
        [Test]
        public void CanGetAccount()
        {
            Http.Stub(
                HttpGet
                    .Url("https://api.cronofy.com/v1/account")
                    .RequestHeader("Authorization", "Bearer " + AccessToken)
                    .ResponseCode(200)
                    .ResponseBody(
                    @"{
  ""account"": {
    ""account_id"": ""acc_567236000909002"",
    ""email"": ""janed@company.com"",
    ""name"": ""Jane Doe"",
    ""default_tzid"": ""Europe/London""
  }
}")
            );

            var actualAccount = Client.GetAccount();
            var expectedAccount = new Account
            {
                Id = "acc_567236000909002",
                Email = "janed@company.com",
                Name = "Jane Doe",
                DefaultTimeZoneId = "Europe/London",
            };

            Assert.AreEqual(expectedAccount, actualAccount);
        }
    }
}


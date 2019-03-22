﻿using System;
using System.Collections.Generic;
using Xunit;

namespace Bootstrap.Admin.Api
{
    public class OnlineTest : ControllerTest
    {
        public OnlineTest(BAWebHost factory) : base(factory, "api/OnlineUsers") { }

        [Fact]
        public async void Get_Ok()
        {
            var users = await Client.GetAsJsonAsync<IEnumerable<OnlineUser>>();
            Assert.Single(users);
        }

        [Fact]
        public async void GetById_Ok()
        {
            var urls = await Client.GetAsJsonAsync<IEnumerable<KeyValuePair<DateTime, string>>>("UnitTest");
            Assert.Empty(urls);
        }

        [Fact]
        public async void Put_Ok()
        {
            var ret = await Client.PutAsJsonAsync<string, bool>("");
            Assert.False(ret);
        }
    }
}

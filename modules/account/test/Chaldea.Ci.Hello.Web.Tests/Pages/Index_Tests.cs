﻿using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Chaldea.Ci.Hello.Pages
{
    public class Index_Tests : HelloWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}

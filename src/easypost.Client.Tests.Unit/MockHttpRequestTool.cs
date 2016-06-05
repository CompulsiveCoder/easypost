using System;

namespace easypost.Client.Tests.Unit
{
    public class MockHttpRequestTool : HttpRequestTool
    {
        public string IntendedResponse = "[mock response]";

        public MockHttpRequestTool ()
        {
        }

        public override string MakeGetRequest (string url)
        {
            return IntendedResponse;
        }
    }
}


﻿namespace Tests.Infra.HTMLEngineTesterHelper.HtmlContext
{
    public interface ITestHtmlProvider 
    {
        string GetHtlmPath(TestContext context);

        string GetRelativeHtlmPath(TestContext context);
    }
}

﻿using H3ml.Services;
using NUnit.Framework;

namespace H3ml.Layout
{
    public class ContextTest
    {
        [Test]
        public void Test()
        {
            var html_context = new context();
            html_context.load_master_stylesheet(Resources.master_css);
        }
    }
}

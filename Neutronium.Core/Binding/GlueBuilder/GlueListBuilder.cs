﻿using System;
using System.Collections;
using System.Collections.Generic;
using Neutronium.Core.Binding.GlueObject;
using Neutronium.Core.Binding.GlueObject.Factory;
using Neutronium.Core.WebBrowserEngine.Window;

namespace Neutronium.Core.Binding.GlueBuilder
{
    internal sealed class GlueListBuilder : GlueAllCollectionBuilder, ICsToGlueConverter
    {
        internal GlueListBuilder(IGlueFactory factory, IWebBrowserWindow context, CSharpToJavascriptConverter converter, Type collectionType):
            base(factory, context, converter, collectionType)
        {
        }

        public IJsCsGlue Convert(object @object) 
        {
            var collection = (IList)@object;
            var arrayResult = Build(collection);
            arrayResult.SetChildren(Convert(collection));
            return arrayResult;
        }

        private List<IJsCsGlue> Convert(IList collection) 
        {
            var list = new List<IJsCsGlue>(collection.Count);
            return AppendToList(list, collection);
        }
    }
}
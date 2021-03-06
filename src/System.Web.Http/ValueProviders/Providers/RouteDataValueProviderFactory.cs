﻿using System.Globalization;
using System.Web.Http.Controllers;

namespace System.Web.Http.ValueProviders.Providers
{
    public class RouteDataValueProviderFactory : ValueProviderFactory, IUriValueProviderFactory
    {
        public override IValueProvider GetValueProvider(HttpActionContext actionContext)
        {
            if (actionContext == null)
            {
                throw Error.ArgumentNull("actionContext");
            }

            return new RouteDataValueProvider(actionContext, CultureInfo.InvariantCulture);
        }
    }
}

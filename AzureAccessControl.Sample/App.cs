﻿using Cheesebaron.MvxPlugins.AzureAccessControl.ViewModels;
using Cirrious.MvvmCross.ViewModels;

namespace AzureAccessControl.Sample
{
    public class App 
        : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<DefaultIdentityProviderCollectionViewModel>();
        }
    }
}
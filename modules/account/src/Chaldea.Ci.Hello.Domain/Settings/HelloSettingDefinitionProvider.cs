﻿using Volo.Abp.Settings;

namespace Chaldea.Ci.Hello.Settings
{
    public class HelloSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(HelloSettings.MySetting1));
        }
    }
}

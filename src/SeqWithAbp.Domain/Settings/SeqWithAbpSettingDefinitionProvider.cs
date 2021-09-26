using Volo.Abp.Settings;

namespace SeqWithAbp.Settings
{
    public class SeqWithAbpSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(SeqWithAbpSettings.MySetting1));
        }
    }
}

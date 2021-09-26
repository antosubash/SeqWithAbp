using SeqWithAbp.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace SeqWithAbp.Permissions
{
    public class SeqWithAbpPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(SeqWithAbpPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(SeqWithAbpPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<SeqWithAbpResource>(name);
        }
    }
}

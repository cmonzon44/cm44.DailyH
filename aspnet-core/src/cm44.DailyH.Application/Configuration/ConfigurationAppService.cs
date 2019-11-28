using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using cm44.DailyH.Configuration.Dto;

namespace cm44.DailyH.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : DailyHAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

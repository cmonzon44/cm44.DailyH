using System.Threading.Tasks;
using cm44.DailyH.Configuration.Dto;

namespace cm44.DailyH.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

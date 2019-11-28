using Abp.AutoMapper;
using cm44.DailyH.Authentication.External;

namespace cm44.DailyH.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}

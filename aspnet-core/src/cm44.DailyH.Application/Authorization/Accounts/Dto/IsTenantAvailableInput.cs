using System.ComponentModel.DataAnnotations;
using Abp.MultiTenancy;

namespace cm44.DailyH.Authorization.Accounts.Dto
{
    public class IsTenantAvailableInput
    {
        [Required]
        [StringLength(AbpTenantBase.MaxTenancyNameLength)]
        public string TenancyName { get; set; }
    }
}

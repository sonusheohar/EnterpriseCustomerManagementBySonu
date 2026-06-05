using CRM.Domain.Common;
using CRM.Domain.Enums;

namespace CRM.Domain.Entities
{
    public class Customer: AuditableEntity
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public CustomerStatus Status { get; set; }
        public string TenantId { get; set; } = string.Empty;
    }
}

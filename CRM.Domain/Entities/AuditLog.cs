using CRM.Domain.Common;

namespace CRM.Domain.Entities
{
    public class AuditLog: AuditableEntity
    {
        public string TableName { get; set; } = string.Empty;
        public string Action { get; set; } = string.Empty;
        public string RecordId { get; set; } = string.Empty;
        public string OldValues { get; set; } = string.Empty;
        public string NewValues { get; set; } = string.Empty;
    }
}

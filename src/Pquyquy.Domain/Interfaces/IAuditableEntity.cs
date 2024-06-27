namespace Pquyquy.Domain.Interfaces;

public interface IAuditableEntity
{
    bool IsActive { get; set; }

    bool IsDeleted { get; set; }

    string CreatedBy { get; set; }

    DateTime CreatedAt { get; set; }

    string ModifiedBy { get; set; }

    DateTime ModifiedAt { get; set; }

    string Remarks { get; set; }
}

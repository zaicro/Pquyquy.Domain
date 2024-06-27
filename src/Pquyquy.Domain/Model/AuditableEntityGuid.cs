namespace Pquyquy.Domain.Model;

public abstract class AuditableEntityGuid : AuditableEntity, IAuditableEntityGuid
{
    [Key, Column("guid", TypeName = "uniqueidentifier", Order = 1)]
    [Required(ErrorMessage = "The {0} field is required")]
    [JsonProperty("guid", Order = 1)]
    public Guid Guid { get; set; }

    #region ShouldSerialize
    [NotMapped]
    [JsonIgnore]
    public bool NotSerializeGuid { get; set; }

    public bool ShouldSerializeGuid()
    {
        return !NotSerializeGuid;
    }
    #endregion
}
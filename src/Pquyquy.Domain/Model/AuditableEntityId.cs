namespace Pquyquy.Domain.Model;

public abstract class AuditableEntityId : AuditableEntity, IAuditableEntityId
{
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    [Key, Column("id", TypeName = "bigint", Order = 1)]
    [Required(ErrorMessage = "The {0} field is required")]
    [JsonProperty("id", Order = 1)]
    public long Id { get; set; }

    #region ShouldSerialize
    [NotMapped]
    [JsonIgnore]
    public bool NotSerializeId { get; set; }

    public bool ShouldSerializeId()
    {
        return !NotSerializeId;
    }
    #endregion
}
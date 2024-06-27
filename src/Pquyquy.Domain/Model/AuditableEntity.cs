namespace Pquyquy.Domain.Model;

public abstract class AuditableEntity : IAuditableEntity
{
    protected AuditableEntity()
    {
        IsActive = true;
        IsDeleted = false;
        CreatedBy = "Unauthorized";
        CreatedAt = DateTime.UtcNow;
        ModifiedBy = "Unauthorized";
        ModifiedAt = DateTime.UtcNow;
        Remarks = "Default Domain";
    }

    [Column("isActive", TypeName = "bit", Order = 101)]
    [Required(ErrorMessage = "The {0} field is required")]
    [JsonProperty("isActive", Order = 101)]
    [ScaffoldColumn(false)]
    public bool IsActive { get; set; }

    [Column("isDeleted", TypeName = "bit", Order = 102)]
    [Required(ErrorMessage = "The {0} field is required")]
    [JsonProperty("isDeleted", Order = 102)]
    [ScaffoldColumn(false)]
    public bool IsDeleted { get; set; }

    [Column("createdBy", TypeName = "varchar", Order = 103)]
    [StringLength(50, ErrorMessage = "The {0} field cannot exceed {1} characters.")]
    [Required(ErrorMessage = "The {0} field is required")]
    [JsonProperty("createdBy", Order = 103)]
    [ScaffoldColumn(false)]
    public string CreatedBy { get; set; }

    [Column("createdAt", TypeName = "datetime", Order = 104)]
    [Required(ErrorMessage = "The {0} field is required")]
    [JsonProperty("createdAt", Order = 104)]
    [ScaffoldColumn(false)]
    public DateTime CreatedAt { get; set; }

    [Column("modifiedBy", TypeName = "varchar", Order = 105)]
    [StringLength(50, ErrorMessage = "The {0} field cannot exceed {1} characters.")]
    [Required(ErrorMessage = "The {0} field is required")]
    [JsonProperty("modifiedBy", Order = 105)]
    [ScaffoldColumn(false)]
    public string ModifiedBy { get; set; }

    [Column("modifiedAt", TypeName = "datetime", Order = 106)]
    [Required(ErrorMessage = "The {0} field is required")]
    [JsonProperty("modifiedAt", Order = 106)]
    [ScaffoldColumn(false)]
    public DateTime ModifiedAt { get; set; }

    [Column("remarks", TypeName = "varchar", Order = 107)]
    [Required(ErrorMessage = "The {0} field is required")]
    [JsonProperty("remarks", Order = 107)]
    [ScaffoldColumn(false)]
    public string Remarks { get; set; }

    #region ShouldSerialize
    [NotMapped]
    [JsonIgnore]
    public bool NotSerializeIsActive { get; set; }
    public bool ShouldSerializeIsActive()
    {
        return !NotSerializeIsActive;
    }

    [NotMapped]
    [JsonIgnore]
    public bool NotSerializeIsDeleted { get; set; }
    public bool ShouldSerializeIsDeleted()
    {
        return !NotSerializeIsDeleted;
    }

    [NotMapped]
    [JsonIgnore]
    public bool NotSerializeCreatedBy { get; set; }
    public bool ShouldSerializeCreatedBy()
    {
        return !NotSerializeCreatedBy;
    }

    [NotMapped]
    [JsonIgnore]
    public bool NotSerializeCreatedAt { get; set; }
    public bool ShouldSerializeCreatedAt()
    {
        return !NotSerializeCreatedAt;
    }

    [NotMapped]
    [JsonIgnore]
    public bool NotSerializeModifiedBy { get; set; }
    public bool ShouldSerializeModifiedBy()
    {
        return !NotSerializeModifiedBy;
    }

    [NotMapped]
    [JsonIgnore]
    public bool NotSerializeModifiedAt { get; set; }
    public bool ShouldSerializeModifiedAt()
    {
        return !NotSerializeModifiedAt;
    }


    [NotMapped]
    [JsonIgnore]
    public bool NotSerializeRemarks { get; set; }
    public bool ShouldSerializeRemarks()
    {
        return !NotSerializeRemarks;
    }
    #endregion
}

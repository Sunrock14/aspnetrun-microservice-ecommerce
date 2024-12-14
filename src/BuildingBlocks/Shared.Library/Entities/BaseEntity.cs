﻿namespace Shared.Library.Entities;

public abstract class BaseEntity
{
    public virtual int Id { get; set; }
    public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
    public virtual DateTime ModifiedDate { get; set; } = DateTime.Now;
    public virtual bool IsActive { get; set; } = true;
    public virtual string CreatedByName { get; set; } = "Created By System";
    public virtual string ModifiedByName { get; set; } = "Created By System";
    public virtual string Note { get; set; } = string.Empty;

}

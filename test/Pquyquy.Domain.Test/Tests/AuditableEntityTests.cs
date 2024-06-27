namespace Pquyquy.Domain.Test.Tests;

[TestFixture]
public class AuditableEntityTests
{
    [Test]
    public void Constructor_SetsDefaultValues()
    {
        var entity = new TestAuditableEntity();

        Assert.That(entity.IsActive, Is.True);
        Assert.That(entity.IsDeleted, Is.False);
        Assert.That("Unauthorized", Is.EqualTo(entity.CreatedBy));
        Assert.That("Unauthorized", Is.EqualTo(entity.ModifiedBy));
        Assert.That("Default Domain", Is.EqualTo(entity.Remarks));
    }

    [Test]
    public void ShouldSerializeIsActive_ReturnsTrue_WhenNotSerializeIsActiveIsFalse()
    {
        var entity = new TestAuditableEntity { NotSerializeIsActive = false };
        Assert.That(entity.ShouldSerializeIsActive(), Is.True);
    }

    [Test]
    public void ShouldSerializeIsActive_ReturnsFalse_WhenNotSerializeIsActiveIsTrue()
    {
        var entity = new TestAuditableEntity { NotSerializeIsActive = true };
        Assert.That(entity.ShouldSerializeIsActive(), Is.False);
    }
}

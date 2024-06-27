namespace Pquyquy.Domain.Test.Tests;

[TestFixture]
public class AuditableEntityIdTests
{
    [Test]
    public void ShouldSerializeId_ReturnsTrue_WhenNotSerializeIdIsFalse()
    {
        var entity = new TestAuditableEntityId { NotSerializeId = false };
        Assert.That(entity.ShouldSerializeId(), Is.True);
    }

    [Test]
    public void ShouldSerializeId_ReturnsFalse_WhenNotSerializeIdIsTrue()
    {
        var entity = new TestAuditableEntityId { NotSerializeId = true };
        Assert.That(entity.ShouldSerializeId(), Is.False);
    }
}

namespace Pquyquy.Domain.Test.Tests;

[TestFixture]
public class AuditableEntityGuidTests
{
    [Test]
    public void ShouldSerializeGuid_ReturnsTrue_WhenNotSerializeGuidIsFalse()
    {
        var entity = new TestAuditableEntityGuid { NotSerializeGuid = false };
        Assert.That(entity.ShouldSerializeGuid(), Is.True);
    }

    [Test]
    public void ShouldSerializeGuid_ReturnsFalse_WhenNotSerializeGuidIsTrue()
    {
        var entity = new TestAuditableEntityGuid { NotSerializeGuid = true };
        Assert.That(entity.ShouldSerializeGuid(), Is.False);
    }
}

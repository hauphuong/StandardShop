using StandardShop.Data.Enums;

namespace StandardShop.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { get; set; }
    }
}
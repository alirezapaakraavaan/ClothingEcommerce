namespace _01_EcommerceQuery.Contract.InventoryQuery
{
    public interface IInventoryQuery
    {
        StockStatus CheckStock(IsInStock command);
    }
}
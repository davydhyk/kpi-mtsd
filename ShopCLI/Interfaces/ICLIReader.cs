namespace ShopCLI.Interfaces
{
    public interface ICLIReader
    {
        public int GetMenuItemNumber();
        public int GetProductId();
        public int GetDestinationId();
        public bool GetConfirm();
    }
}
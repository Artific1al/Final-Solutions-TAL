namespace jsonAPIproject.Repository
{
    public interface IItemRepository
    {
        List<Item> Get();

        Item GetById(int id);

        void Delete(int id);

        Item Add(Item item);
    }
}

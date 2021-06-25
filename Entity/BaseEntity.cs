namespace Entity
{
    public abstract class BaseEntity<TKey>
    {
        public TKey Id { get; set; }
    }
}
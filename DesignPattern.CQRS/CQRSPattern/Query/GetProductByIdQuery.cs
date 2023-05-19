namespace DesignPattern.CQRS.CQRSPattern.Query
{
    public class GetProductByIdQuery
    {   
        public int Id { get; set; }

        public GetProductByIdQuery(int id)
        {
            Id = id;
        }
    }
}

namespace DomainLayer.DB_Model.General
{
    public class Type : ShareField
    {


        public int TypeId { get; set; }
        public int Code { get; set; }
        public int Order { get; set; }
        public int Group { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }



    }
}

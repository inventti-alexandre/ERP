namespace DomainLayer.App_Model.General
{
    public class ServicesResult
    {

        public bool Success { get; set; }
        public object Data { get; set; }
        public int ErrorCount { get; set; }
        public string Message { get; set; }
        public string InnerExeption { get; set; }

        


    }
}

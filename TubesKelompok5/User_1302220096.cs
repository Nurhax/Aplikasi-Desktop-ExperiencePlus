namespace TubesKelompok5
{
    public class User_1302220096
    {
        public string username { get; set; }
        public string passwordHashed { get; set; }
        public string email { get; set; }
    }

    public class ServiceResponse<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }
}

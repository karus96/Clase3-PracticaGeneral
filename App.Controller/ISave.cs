namespace App.Controller
{
    public interface ISave
    {
        public string Path { get; set; }
        public bool Save(string data);

    }
}

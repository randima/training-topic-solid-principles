namespace Sample
{
    public class Report
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public void Print()
        {
            Console.WriteLine($"Printing: {Title} - {Content}");
        }
        
        //public void SaveToFile(string filename)
        //{
        //    Console.WriteLine($"Saving {Title} to {filename}");
        //}

        //public void SendByEmail(string email)
        //{
        //    Console.WriteLine($"Sending report '{Title}' to {email}");
        //}
    }
}

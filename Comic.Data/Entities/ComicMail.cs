namespace Comic.Data.Entities
{
    public class ComicMail
    {
        public string FromMailId { get; set; } = "hikistudio.comic@gmail.com";

        public string FromMailIdPassword { get; set; } = "@Quang810";

        public List<string> ToMailIds { get; set; } = new List<string>();

        public string Subject { get; set; } = "";

        public string Body { get; set; } = "";

        public bool IsBodyHtml { get; set; } = true;

        public List<string> Attachments { get; set; } = new List<string>();
    }
}

namespace dependecy_invertion
{
    public class Email : IMensaje
    {
        public string Content { get; set; }
        public string Subject { get; set; }
        public Email(string subject, string content)
        {
            this.Subject = subject;
            this.Content = content;
        }
        public void envia_mensaje(){

        }
    }
}
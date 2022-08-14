namespace ModuleEvents
{
    public class MailService
    {
        public void onVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("MailSerice: Sending an emial...");
        }
    }
}
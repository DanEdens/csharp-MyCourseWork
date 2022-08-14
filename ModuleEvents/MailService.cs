namespace ModuleEvents
{
    public class MailService
    {
        public void onVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MailSerice: Sending an email..." + e.Video.Title);
        }
    }
}
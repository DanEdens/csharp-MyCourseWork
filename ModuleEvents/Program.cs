namespace ModuleEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); //publisher
            var mailService = new MailService(); //subscriber

            videoEncoder.Encode(video);
        }
    }

    public class MailService
    {
        public void onVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("MailSerice: Sending an emial...");
        }
    }
}
namespace ModuleEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); //publisher
            var mailService = new MailService(); //subscriber

            videoEncoder.VideoEncoded += mailService.onVideoEncoded;

            videoEncoder.Encode(video);
        }
    }
}
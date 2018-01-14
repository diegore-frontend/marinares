namespace Marinares.Data
{
    public class Response<TStatus, TContent>
    {
        public TStatus Status { get; set; }
        public TContent Content { get; set; }

        public Response()
        {

        }

        public Response(TStatus status, TContent content)
        {
            this.Status = status;
            this.Content = content;
        }

    }
}
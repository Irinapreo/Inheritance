
namespace Inheritance;

internal class NewsUploader : User
{
    public NewsUploder(string username, string email) : base(username, email)
    {

    }
    public bool UploadNews(string title, string content)
    {
        if (content.Length > 0)
        {
            Console.WriteLine("Uploaded news: ", +title);
            return true;

        }
        else
        {
            return false;
        }
    }
}

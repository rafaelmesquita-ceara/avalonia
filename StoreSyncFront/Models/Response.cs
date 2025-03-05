namespace StoreSyncFront.Models;

public class Response
{
    public int Status { get; set; }
    public string? Body { get; set; }

    public Response(int status, string? body)
    {
        Status = status;
        Body = body;
    }
}
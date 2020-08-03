namespace MyNameSpace
{
	public interface IInterface
	{
		Response Process(Request rq);
		
	}
	public class Request
	{
		
	}

	public class Response
	{
		public string Text { get; set; }
	}
}


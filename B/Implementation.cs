namespace MyNameSpace
{
	public class Implementation
	{
		public OtherInterface OtherInterface { get; set; }

		Response Process(Request rq)
		{
			return OtherInterface.ReturnResponse();
		}
	}
}

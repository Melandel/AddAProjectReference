namespace MyNameSpace
{
	public class OtherInterfaceImplementation : OtherInterface
	{
		Response OtherInterface.ReturnResponse(){
			var DS = new DataStructure() { String = "toto" };
			return new Response() { Text = DS.String };
		}
		
	}
}

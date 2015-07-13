namespace Bug31772
{
	interface IApi {}

	public class MyApi : IApi {}

	public class MyApiClient
	{
		IApi Api { get; }

		public MyApiClient()
		{
			Api = new MyApi();
		}
	}
}

namespace Bug31772
{
	public struct MyModel
	{
		public MyModel(string MyMember)
		{
			this.MyMember = MyMember;
		}

		public string MyMember { get; set; }
	}
}

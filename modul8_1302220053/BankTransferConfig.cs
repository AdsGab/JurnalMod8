using System;

public class BankTransferConfig
{
	public string lang {  get; set; }
	public Transfer transfer { get; set; }
	public string[] methods { get; set; }
	public Confirmation confirmation { get; set; }
	public BankTransferConfig( string Lang, Transfer t, string[] Methods, Confirmation c)
	{
		lang = Lang;
		transfer = t;
		methods = Methods;
		confirmation = c;
	}
	
		
	
}

public class Transfer
{
	public int treshhold { get; set; }
	public int low_fee { get; set; }
	public int high_fee { get; set; }
}

public class Confirmation
{
	public string en { get; set; }
	public string id { get; set; }

}
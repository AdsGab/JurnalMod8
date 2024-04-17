using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

public class BankConfig
{
	public BankTransferConfig config;
	public const String filePath = @"BankTransferConfig.json";
	public BankConfig() { 
		try
		{
			ReadConfigFile();									
		}
		catch(Exception)
		{
			SetDefault();
			WriteNewConfigFile();
		}
	}
	private BankTransferConfig ReadConfigFile() { 
		String configJsonData = File.ReadAllText(filePath);
		config = JsonSerializer.Deserialize<BankTransferConfig>(configJsonData);
		return config;
	}

	private void SetDefault() {
		Transfer t = new Transfer();
		t.treshhold =25000000;
		t.low_fee = 6500;
		t.high_fee = 15000;
		Confirmation c = new Confirmation();
		c.en = "yes";
		c.id = "ya";
        config  = new BankTransferConfig("en", t, ["RTO (real-time)","SKN","RTGS","BI FAST"],c);
	}
	private void WriteNewConfigFile () {
		JsonSerializerOptions options = new JsonSerializerOptions()
		{
			WriteIndented = true
		};
		String jsonString = JsonSerializer.Serialize(config, options);
		File.WriteAllText (filePath, jsonString);
	}


}

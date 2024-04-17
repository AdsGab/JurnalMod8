using System.Numerics;

class program
{
    static void Main(String[] args)
    {
       int BiayaTransfer;

        BankConfig bank = new BankConfig();

        if (bank.config.lang == "en") {
            Console.WriteLine("Please Insert the ammount of money to transfer: ");
        }
        else if (bank.config.lang == "id")
        {
            Console.WriteLine("Masukan jumlah uang yang akan di transfer: ");
        }
        int jumlahTransfer = Convert.ToInt32(Console.ReadLine());
        if (jumlahTransfer <= bank.config.transfer.treshhold)
        {
            BiayaTransfer =bank.config.transfer.low_fee;
        }
        else
        {
            BiayaTransfer =  bank.config.transfer.high_fee;
        }
        if(bank.config.lang == "en")
        {
            Console.WriteLine("Transfer fee = " + BiayaTransfer);
            Console.WriteLine("Total ammount  = " + (jumlahTransfer + BiayaTransfer));
            Console.WriteLine("Select transfer method: ");
        }
        else if (bank.config.lang == "id")
        {
            Console.WriteLine("Biaya Transfer " + BiayaTransfer);
            Console.WriteLine("Total biaya  = " + (jumlahTransfer + BiayaTransfer));
            Console.WriteLine("Pilih metode transfer: ");

        }
        int i = 0;
        foreach (var item in bank.config.methods)
        {
            i++;
            Console.WriteLine(i+ ". " + i+ "." +item);
        }
        int transferMethod =  Convert.ToInt32(Console.ReadLine());
        if (bank.config.lang == "en")
        {
            Console.WriteLine("Please type " + bank.config.confirmation.en + " to confirm the transaction: " );
            string confirmed = Console.ReadLine();
            if (confirmed == bank.config.confirmation.en)
            {
                Console.WriteLine("Transfer is completed");
            }
            else
            {
                Console.WriteLine("Transfer is failed");
            }
        }
        else if (bank.config.lang == "id")
        {
            Console.WriteLine("Ketik " + bank.config.confirmation.id + "untuk mengkonfirmasi transaksi: " );
            string confirmed = Console.ReadLine();
            if (confirmed == bank.config.confirmation.id)
            {
                Console.WriteLine("Proses Transfer Berhasil");
            }
            else
            {
                Console.WriteLine("Transfer dibatalkan");
            }

        }
       
        
    }
}
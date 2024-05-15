namespace FirstDemo.Models
{
    public class SummaryModel
    {
        public string Summarytext { get; set; }

        public string Name { get; set; }
        public string Address {  get; set; } 

        public int Amount { get; set; }
 
        public SummaryModel(string summarytext, string name, string address,int x)
        {
            Summarytext = summarytext;
            Name = name;
            Address = address;
            Amount = x+100;
        }
       
       


    }
}
